on 2 november I started this project
I started this project at 8:30 am in the morning.
At 8:37 am  I deleted some stuff which was showed i the powerppoint. 
at 8:58 am I just added a new bootsrap file which gives me the display like a hacker has done.
at 9:02 am I made some changes in the layout file .
at 9:19 am i added dropdown menu and addtional files required for the making of website
at 9:22 am i changed the dropdown menu to content managment menu. 
and i am stuck at navbar menu whihc i cannot figure out wha is going on updated readme
but now i have figured it out and my drop down is working properly

11/14/2022
at 5:30pm I installed NugetPackages into Padambook.DataAccess
At 5:31 pm I changed the namespace to PadamBookStore.DataAccess.Data
At 5:46 pm I moved the models folder into Padambooks.models  and added the poject refrence of .DataAccess and .Models to PadambookStore.
I chaned the name of models folder to view models.
At 5:48 pm I changed the namespace in erros view models.cs

at 6:01pm I made a class name SD.cs in Padambookstore.utility

by 6:53 I modified the properties of the class and added the customner in  Area folder. 
And changed the startup.cs file 

by 6:55pm moved the home controller file in customer folder. and added the root in Home controller file . 
after that I added New Admin in Area' folder. 
At 7:00pm I deleted controller folder. 

At 7:15pm I added modified the database name and saved it. 

at 7:30pm I added the migration  and updated the database. 
I added the migraton package at 7:35pm  addDeaultIdentityMigaration
and ran successfully. 

at 7:40pm I updated the databse and it build succesfully

at 8:00pm I added a new class in models project by naming it as Category.cs 
at 8:07pm I used add-Migration AddCategoryToDb to add the migration to Databae through PM
at 8:11pm I added "public  DbSet<Category> Categories { get; set; }" in ApplicationDBcontext.cs

8:40pm
Added new DB context and migration through  add-Migration AddCategoryToDb on PM

8:49pm 
I added a new folder in Migrations named as Respostory in which I added a new folder named IRespository.

at 9:07 
I added content provided by the professor in the IRespository.cs

at 9:16pm 
I added the methods for using the CRUD in IRespository

At 9:41 pm 
We have done changes provided throguh the text file and saved it in Repository.cs

At 9:46 pm
I created two files one named ICategoryRepsitory and the other one named as Category Repository 

11/15/2022
at 7:52am in the morning I did cahnges in both ICategoryRepsitory.cs CategoryRepoitory.cs

at 8:27am in morning I installed the Nuget PAckages of the DApper and it actually started working ... haha :)

by 8:52am i implmented the ISP interface in the SP_Call.cs file and updated the chnages to the github. 

at 9:47am I added a new interface in IReposiorty file named as UnitOfWork.cs
 at 9:48am I added a new class in Repository file names as UnitOfWork.cs

 at 10:39 am I created a new folder in views named as category.

 2022/11/22
 time: 9:00am
 I rechecked all my files and looked out for all the errors. 

 11:00am
 I found the problems which were producing erros and cleared all the erros. 

 12:00 pm
 the error of local host was not showing , so i fixed the error because og the database NS THE ERROR WAS IN VIEWSTART.CSHTML . 

 2022/11/23
 
 1:00pm
 I created new jsfile name category.js wwwroot and saved the changes in that file after that I added the section call of the category.js in
 the cs.html file. 

 1:30pm 
 I created the Upsert file and modified it  with the given code and another partial view file name (_CrateAndBackToListButton.cshtml)

 2:00pm
 in category controller I added the void save() to interface Iunitofwork which allow to save method. 

 2:30pm 
 I am finally done with part the ENTIRE PART 2  HAHA:)
  
  BREAK TIME

  4:25pm
  I created a covertype.cs file in viewmodels folder

  4:32pm
  I made two new class files one in Repository folder named CoverTypeRepository.cs and one in IRepository folder named as ICoverTypeRepository.cs .

  4:36pm 
  I commmit the changes.

  5:00 pm 
  I set all the nuget commands and added migration by using Add-migration AddCoverTypeToDb  {20221115014025_AddCategoryToDb.cs} and then 
  updated it by using Update-database command. 

  at 5:05pm 
  I check my output and wooohooo it is running successfuly. 

  5:30pm
  I created new class in .models project named as Product.cs and entered the code mentioned in the powerpoint. 
  
  
  6:14 pm
  I added the given changes to the applicationDbcontext.cs file .

  by 
  7:00pm I added some files which i did not added which were, category.js file , CoverType.js file. 
   
  7:15 pm 
  I added two new files in category folder named as index.cshtml and upsert.cshtml and I updated them.
  
  7:20pm
  I added two new files in Co verType folder named as _Viewimports.cshtml and _Viewstart.cshtml

  7:50pm 
  I am done with my 1st part of 3rd part. phewwwwwwwww:)

   7:55pm
   I added ProductController.cs file to controllers folder.

   2022/11/24

   8:10am
   I finally found the error whihc was coming in Productcontroller.cs file in upsert method and yes i cleared it. 
   haha

   8:50am
   It took me one hour to fidgure out the error which was coming in product controller.cs 
   and I finally cleared it. yeahhh..1

  Did some changes in prodcutcontroller.cs file and my API methods of Get Post and Delete are working. 
  
  9:00am
  I created an index view in  product file and copied the code from Index.cshtml from categories folder to Index.cshtml file in product folder as stated in the ppt.

  9:13am
  I did the changes in Index.cshtml file in product and saved it and updated on github repository.

  9:15 am 
  I made a duplicate of category.js and pasted in js folder named as product.js file.

  9:20 am
  I modified the _Layout.cshtml by adding a new linnk to it named as product 
  "<a class="dropdown-item" asp-area="Admin" asp-controller="Product" asp-action="Index">Product</a>"

  and I guess I am done with paer 2 of third section phewwww......



