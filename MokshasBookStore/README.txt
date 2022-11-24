14 November 2022

0345: Creating MokshasBookStore application all again because I was caught up with an error which I was not able to solve.
Created MVC web application with project name MokshasBookStore
Changed authentication to individual accounts
then checked configure for HTTPS
and enabled Razor runtime compilation.

0347: Build the solution and run IIS Express to check whether it is running or not
yeeeee.. my project is successfully running.

================== Part-1 (1.1) Review ====================

Reviewed files inside Controllers, Models and Views

0351: Reviewed startup.cs file and removed AddRazorPages from IServiceCollection

0357: Edited content of _Layout.cshtml file in Views->Shared folder.

0400: Reviewed all the files found inside shared folder

================== Part-1 (1.2) Debugging =====================

0488: Added breakpoints in HomeController.cs file on IAction Index and Privacy and run the program

================== Part-1 (1.3) Bootstrap =====================

0416: Selected theme from Bootswatch.com and downloaded bootstrap.css file which I kept inside wwwroot/lib/bootstrap/dist/css.
Then I changed the content of site.css file as given

0421: Changed some classes in _Layout.cshtml file to give color layout for my web applications

0426: Run the program and saw changes in the layout and text color of my application.

0434: Added extra stylesheets and scripts in _Layout.cshtml file.

0440: Created dropdown menu in _Layout.cshtml file and checked by running the program. Also changed name from dropdown to Content Management

================== Part-1 (1.4) Add Projects and Modify =====================

0449: Added 3 projects in Solution MokshasBookStore Named:
MokshasBooks.DataAccess
MokshasBooks.Models
MokshasBooks.Utility
 and then copied data folded and pasted it in MokshasBooks.DataAccess project

0454: Deleted migrations folder

0457: Installed Microsoft EntityFramework Relational, SqlServer and Identity in .DataAccess project. 

0459: Modified namespace to .DataAccess.Data in ApplicationDbContext.cs file.

0502: Deleted class1.cs file from all projects.

0506: Moved models folder to MokshasBooks.Models
In MokshasBookStore, Added project reference to .DataAccess and .Models projects.
Rename Models folder to ViewModels

0509: Rename namespace in ErrorViewModel.cs file

0510: Found error in ApplicationDbContext inside startup.cs file
Solved it by adding "using MokshasBookStore.DataAccess.Data" class library;

0513: Again error in Error.cshtml file which I solved by referencing to ErrorViewModel

0514: Error in Homecontroller.cs file
solved by adding using directive for models.

0516: Successfully run the program.

0519: Added SD.cs class in MokshasBookStore.Utility project and modified the property to public static and then added .utility as a 
project reference in MokshasBookStore project and MokshasBookStore.DataAccess project.

0525: Added customers areas in the area folder.
Edited endpoints in ScaffoldingReadMe.txt file and changed pattern in startup.cs file

0534: Moved HomeController.cs to the Area -> Customer -> Controller folder and deleted models and data from it.

0537: Moved home folder from main views to Area -> Customer -> Views folder and at last changed namespace in HomeController.cs file.

0538: Now its time to run the application
0539: Found error in running the program which was about routing of customers

0545: solved by changing area=customers in startup.cs file.

0546: Successfully run the  application

0549: Copied _ViewImports.cshtml and _ViewStart.cshtml file to Areas -> Customer -> Views folder and changed path in _ViewStart.cshtml file.

0552: Added adim in Area folder and them copied both _ViewImports.cshtml and _ViewStart.cshtml files in it and deleted
data and models folder from it.
Then deleted controller folder.

0553: Successfully run my application and part-1 is complete :)


******************************************************* PART - 2 ************************************************************

================== Part-2 (2.1) Create the DB =====================

0859: Starting with part 2

0900: Build the solution and checked by running the program.

0903: Edited appsetting.json file

0906: Added 20221115020959_AddDefaultIdentityMigration.cs migration but got error

0910: found solution, I need to install microsoft entityframework for sqlserver 

0914: Added migration

0918: updated database and saw MokshasBookStore in SqlServer

0922: Reviewed AddDefaultIdentityMigration file and added types in it.

0924: Reviewed updated database on SqlServer.

0931: Added new class in models project named category.cs and edited its content

0933: Added migration named AddCategoryToDb in .DataAccess project

0936: Error: was not able to add using MokshasBook.Models in ApplicationDbContext and error in category
0940: solved: created public class in Category.cs file

0941: Added migration again and updated datase

0942: No content is added automatically in AddCategoryToDb file :(

0945: Got the solution
deleted existing AddCategoryToDb and Added again
yeeeeehhhhhhhhh.... Got those content

0947: Updated database and saw dbo.categories on Sql Server.

================== Part-2 (2.2) Repository =====================

0953: Created new folder named repository and then IRepository folder inside it.

1018: created IRepository.cs file inside IRepository folder

1024: Modified its content

1026: Made Respository.cs file in Repository folder.

1033: Modified Repository.cs file but there was an error
solved error by implementing interface
and other errors by adding using directives.

1040: Created CategoryRepository.cs and ICategoryRepository.cs file in Repository folder.

1049: Modified content of CategoryRepository.cs file 

1051: Modified ICategoryRepository.cs file 
Error in CategoryRepository.cs file 
solved by implementing interface.

1056: Again modified content of CategoryRepository.cs file.

Taking a break

1205: Created ISP_Call.cs interface in IRepository folder
1207: installed dapper

1212: Modified content inside ISP_Call.cs file

1214: Created SP_Call.cs class file in Repository folder and implemented ISP_Call in it
Added content but caught with error
solved by implementing interface

1230: Modified content inside SP_Call.cs file

1236: Created IUnitOfWork.cs file in IRepository folder and edited its content
then added UnitOfWork in Repository folder.

1239: added content inside UnitOfWork.cs class file

1242: Edited ConfigureService in Startup.cs file.

1243: Successfully builded the application with no failure

================== Part-2 (2.3) Category CRUD =====================

1246: Created categorycontroller.cs file in Areas-> Admin -> Controllers folder

1257: Edited CategoryController.cs file.

0104: Created new folder in Areas -> Admin -> Views -> Category
In category, created index.cshtml view and added content inside it.

0106: Successfully run my web application :)

0109: Added category in _Layout.cshtml file in dropdown

0110: Run the program and checked by clicking on content management whether category is added or not.... successfully it is added

0117: In Index.cshtml file added edit and trash button from fontAwesome.

0126: Created category.js in wwwroot/js folder and edited its content
added category.js file script in Index.cshtml file

0130: Updated CategoryController.cs file
0132: Created Upsert.cshtml file in  Admin/Views/Category folder and modified its content

0140: In general Views/Shared folder I made partial view for _CreateAndBackToListButton and _EditAndBackToListButton and write some content
inside it

0151: Updated Upsert.cshtml file as per instruction and then added asp-action for upsert in Index.cshtml file

0153: Successfully run the program and created new category

0157: Modified Upsert.cshtml file and added @script call tp validate input

0158: Run the program again successfully :)

0202: Created Upsert POST action in CategoryController.cs
Removed _db.SaveChanges from categoryRepositoy.cs file

0207: run the application successfully and tried to update my changes in it :) :)

0211: Added HTTPDelete in CategoryController.cs file
and implemented it is category.js file

0216: Updated categpry.js file

0217: YEEEEEAAAAHHHHHHHH.... successfully run my program and I am able to add, edit and delete category

15 November 2022

1017: Build the project again in college dektop 
installed microsoft entityframefork SqlServer 
Updated database

1019: Now its time to run the application to confirm

1020: Ohh, I am not able to open it in browser

1021: I remember, professor told us to comment out sslPort in launchSetting.json file

1022: Running application again

1023: Successfully am able to run my application :)

=======================================================================================================================

**************************************** PART 3 ***************************************** 

11/23/2022

================== Part-3 (3.1) Cover Type CRUD =====================


1138: Starting with part 3 of assignment 2

1143: Build succeeded

1144: Checked by running my program.

1150: Updated database

1205: created CoverType.cs file in Models project
Added ID and Name fields in it

1207: Added migration witn name AddCoverTypeToDb by running command in console
I need to change default project to build it successfully

1210: Created CoverType DbSet in ApplicationDbContext.cs file

1216: Deleted migration and then re run

1217: updated database

1218: Yeeeeeehhhhhhhhhh... CoverTypes is added on my SqlServer

1229:  My Visual studio was crashed.

1240: Made CoverTypeRepository.cs file in Repository folder
and ICoverTypeRepository.cs interface in IRepository folder

1244: Modified CoverTypeRepository.cs file

1251: Updated both CoverType Repository files

1252: Build successfull








