var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddContoller //controllerla çalýþacaksan

//builder.Services.AddRazorPages //Razorlar ile çalýþýlacaksa


builder.Services.AddControllersWithViews(); //viewe ihtiyaç varsa bunu kullanýrýz.
var app = builder.Build(); //buradan build ediliyor.

app.UseStaticFiles();
app.UseRouting();

//controller=home/action=index/?id
//app.MapDefaultControllerRoute();
//ya daa


app.MapControllerRoute(
name:"default",
pattern:"{controller=Home}/{action=Index}/{id?}"
);



app.Run();
