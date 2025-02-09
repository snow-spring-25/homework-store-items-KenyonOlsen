using Lab02Logic;

namespace Lab02Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreateTest()
    {
        TaskManager Manager = new TaskManager();
        Manager.AddTask("testtitle1", "testDescrptitojntsg1");
        Manager.AddTask("testtitle2", "testDescrptitojntsg2");
        Manager.AddTask("testtitle3", "testDescrptitojntsg3");
        //Assert taskAdded;
        Assert.That(Manager.TaskList.Count == 3);
    }
    [Test]
    public void ToggleTest()
    {

        TaskManager Manager = new TaskManager();
        Manager.AddTask("testtitle1", "testDescrptitojntsg1");
        int id = Manager.TaskList[0].ID;

        Assert.That(Manager.TaskList[0].IsComplete == false);
        Manager.ToggleTaskComplete(id);
        Assert.That(Manager.TaskList[0].IsComplete == true);
        Manager.ToggleTaskComplete(id);
        Assert.That(Manager.TaskList[0].IsComplete == false);

    }
    [Test]
    public void VariableTest()
    {
        TaskManager Manager = new TaskManager();
        Manager.AddTask("testtitle1", "testDescrptitojntsg1");
        Manager.AddTask("testtitle2", "desc2");
        Manager.AddTask("testtitle3", "testDescrptitojntsg3");

        Assert.That(Manager.TaskList[1].Title == "testtitle2");
        Assert.That(Manager.TaskList[1].Description == "desc2");
        Assert.That(Manager.TaskList[1].IsComplete == false);
    }

    [Test]
    public void IdSet()
    {
        var task1=new TaskItem();
        var task2=new TaskItem();
        Assert.That(task2.ID==task1.ID+1);
    }
}
