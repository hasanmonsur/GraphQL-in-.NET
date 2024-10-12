using GraphQLDapperExample;
using GraphQLDapperExample.Data;
using GraphQLDapperExample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// service DI
builder.Services.AddSingleton<DapperContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ProductRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<ProductType>();

var app = builder.Build();

//// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseRouting();

app.MapGraphQL();

app.Run();


