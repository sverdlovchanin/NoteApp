using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp.Extension;

/// <summary>
/// Represents JSON conversion operations
/// </summary>
public static class JsonExtensions
{
    /// <summary>
    /// Serialize object to json
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    /// <param name="obj">serialized object</param>
    /// <returns></returns>
    public static string ToJson<T>(this T obj) => JsonConvert.SerializeObject(obj, Formatting.Indented);


    /// <summary>
    /// Deserialize object from json text
    /// </summary>
    /// <typeparam name="T">result object type</typeparam>
    /// <param name="json">json string</param>
    /// <returns></returns>
    public static T FromJson<T>(this string json) => string.IsNullOrWhiteSpace(json) ? default! : JsonConvert.DeserializeObject<T>(json)!;
}

