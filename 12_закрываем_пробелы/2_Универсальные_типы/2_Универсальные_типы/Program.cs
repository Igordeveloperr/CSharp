using _2_Универсальные_типы;

var response = new Response(200, "{name:'aboba'}");

var dto = new DTObject<Response>(response);
Console.WriteLine(dto.Response.Json);