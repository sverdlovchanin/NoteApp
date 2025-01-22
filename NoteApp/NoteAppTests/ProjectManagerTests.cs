using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NoteApp.Classes;
using NoteApp;
using FluentAssertions;

namespace NoteAppTests;

internal class ProjectManagerTests : TestsBase
{
    [Test]
    public void ShouldSerializeAndSaveProject()
    {
        var testProject = GetTestProject();

        ProjectManager.Save(testProject);

        File.Exists(ProjectManager.PROJECT_LOCATION).Should().BeTrue();
        var result = File.ReadAllText(ProjectManager.PROJECT_LOCATION).FromJson<Project>();
        result.Should().BeEquivalentTo(testProject);
    }

    [Test]
    public void ShouldLoadAndDeserializeProject()
    {
        var testProject = GetTestProject();
        ProjectManager.Save(testProject);

        var result = ProjectManager.Load();
        result.Should().BeEquivalentTo(testProject);
    }

    [Test]
    public void ShouldThrowIfProjectFileCorrupted()
    {
        File.WriteAllText(ProjectManager.PROJECT_LOCATION, "wrong");
        Assert.Throws<JsonReaderException>(() => ProjectManager.Load());
    }
}

