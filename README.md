# ASP.NET Core Web API

Proper example of creating ASP.Net Core Web API and Calling it from POSTMAN for beginner. 

## Model

First I made a directory Model and added a class Student to it.

In this class I added 3 properties/getters and setters where I can work with to make the API.

```
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public int Roll { get; set; } = 0; 
```

## Controller

In the controller directory I made a StudentController.

I first started with making a list of students.

```
 private List<Student> _students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pgp", Roll = 1001 },
            new Student() { Id = 2, Name = "Zidane", Roll = 1002 },
            new Student() { Id = 3, Name = "Cristiano", Roll = 1003 },
            new Student() { Id = 4, Name = "Messi", Roll = 1004 },
        };
```

## Endpoints

After making the list, the fun really starts with the endpoints!

I first made an endpoint to get all the students.

I also did some error-handling by using the NotFound method.

```
        [HttpGet]
        
        public IActionResult Gets()
        {
            if (_students.Count == 0)
            {
                return NotFound("No list found");
            }
            return Ok(_students);
        }
```

After this I also did all the endpoints for POST, PUT and DELETE. Check the exercise :)