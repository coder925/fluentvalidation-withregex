using FluentValidation;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.UseOneOfForPolymorphism();
    setupAction.UseAllOfForInheritance();
});

// Add FV
builder.Services.AddFluentValidationAutoValidation();

// Add FV validators
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

// Add FV Rules to swagger
builder.Services.AddFluentValidationRulesToSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/teachers", () =>
{
    return new List<Teacher> { new Teacher() { ContactInfo = new ContactInfo() }
};

})
.WithOpenApi();

app.MapGet("/students", () =>
{
    return new List<Student> { new Student() { Recipient = new ContactInfo() }
};

})
.WithOpenApi();
app.Run();
