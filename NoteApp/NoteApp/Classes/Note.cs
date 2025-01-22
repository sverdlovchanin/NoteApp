using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Classes;

/// <summary>
/// Define simple note
/// </summary>
public class Note : ICloneable, IValidatableObject, IEquatable<Note>
{
    private const int NameMaxLength = 50;

    /// <summary>
    /// Note name, less or equal 50 chars
    /// </summary>
    public string Name { get; set; } = "[No Name]";

    /// <summary>
    /// <inheritdoc cref="Classes.Category"/>
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Contains note text message
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Note creation time
    /// </summary>
    public DateTime CreateTime { get; set; } = DateTime.Now;

    /// <summary>
    /// Note modification time
    /// </summary>
    public DateTime UpdateTime { get; set; } = DateTime.Now;

    public object Clone() => MemberwiseClone();

    public bool Equals(Note? other) => other?.Name == Name
                                       && other?.Category == Category
                                       && other?.Text == Text
                                       && other?.CreateTime == CreateTime
                                       && other?.UpdateTime == UpdateTime;

    public override bool Equals(object? obj) => obj is Note note && Equals(note);

    public override int GetHashCode() => HashCode.Combine(Name, Category, Text, CreateTime, UpdateTime);

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(Name))
        {
            yield return new ValidationResult($"{nameof(Name)} is required", [nameof(Name)]);
        }

        if (Name?.Length > NameMaxLength)
        {
            yield return new ValidationResult($"{nameof(Name)} should be less or equal {NameMaxLength} chars", [nameof(Name)]);
        }

        if (CreateTime == default)
        {
            yield return new ValidationResult($"{CreateTime} can not be empty", [nameof(CreateTime)]);
        }

        if (UpdateTime == default)
        {
            yield return new ValidationResult($"{UpdateTime} can not be empty", [nameof(UpdateTime)]);
        }

        if (UpdateTime < CreateTime)
        {
            yield return new ValidationResult($"{UpdateTime} can not be less then {CreateTime}", [nameof(CreateTime), nameof(UpdateTime)]);
        }
    }
}