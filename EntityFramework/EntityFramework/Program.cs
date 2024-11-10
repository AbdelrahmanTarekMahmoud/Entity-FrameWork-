using EntityFramework.Data;
using EntityFramework.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using (var context = new ApplicationDbContext())
{

    /*****************************************
               1 - Adding Records
    ******************************************/
    //Method 1: Adding Records Directly Using context.Add()


    //context.Add(new User { Name = "Ahmed", Email = "Ahmed@gmail.com", CreatedAT = DateTime.Now });
    //context.Add(new User { Name = "Khaled", Email = "Khaled@gmail.com", CreatedAT = DateTime.Now });
    //context.Add(new User { Name = "Ibrahim", Email = "Ibrahim@gmail.com", CreatedAT = DateTime.Now });
    //context.Add(new User { Name = "Abdelrahman", Email = "Abdelrahman@gmail.com", CreatedAT = DateTime.Now });
    //context.Add(new User { Name = "Zyad", Email = "Zyad@gmail.com", CreatedAT = DateTime.Now });

    //context.SaveChanges();


    ////Method 2 : Adding Range

    //List<Category> categories = new List<Category>()
    //{
    //    new Category {Name = "Tech"},
    //    new Category {Name = "Eng"},
    //    new Category {Name = "Entertainment"},
    //    new Category {Name = "Sports"},
    //    new Category {Name = "Health"}
    //};

    //context.AddRange(categories);
    //context.SaveChanges();

    ////List<Post> posts = new List<Post>()
    ////{
    ////    new Post{Title = "C#" , Content = "Explain C#" , UserId = 1 , CategoryId = 1 , CreatedAT =  DateTime.Now },
    ////    new Post{Title = "C++" , Content = "Explain C++" , UserId = 2 , CategoryId = 2 , CreatedAT =  DateTime.Now },
    ////    new Post{Title = "C" , Content = "Explain C" , UserId = 3 , CategoryId = 3 , CreatedAT =  DateTime.Now },
    ////    new Post{Title = "GO" , Content = "Explain GO" , UserId = 4 , CategoryId = 4 , CreatedAT =  DateTime.Now },
    ////    new Post{Title = "Java" , Content = "Explain java" , UserId = 5 , CategoryId = 5 , CreatedAT =  DateTime.Now }
    ////};
    ////context.AddRange(posts);
    ////context.SaveChanges();

    //List<Comment> comments = new List<Comment>()
    //{
    //    new Comment { Content = "Fantastic post on C#!", UserId = 1, PostId = 2 },
    //    new Comment { Content = "I really enjoyed the C++ article.", UserId = 2, PostId = 3 },
    //    new Comment { Content = "C is the backbone of many systems.", UserId = 3, PostId = 4 },
    //    new Comment { Content = "Go language is very efficient.", UserId = 4, PostId = 5 },
    //    new Comment { Content = "Java is versatile!", UserId = 5, PostId = 6 }
    //};

    //context.AddRange(comments);
    //context.SaveChanges();



    ///*****************************************
    //           2 - Updating Records
    //******************************************/



    //Method 1: Updating a Single Record

    //var user = context.Users.FirstOrDefault(u => u.Id == 2);
    //if (user != null)
    //{
    //    user.Email = "Khalid@Yahoo.com";
    //    user.CreatedAT = DateTime.Now;
    //    context.SaveChanges();
    //}
    //else
    //{
    //    Console.WriteLine("User not Found");
    //}

    //Mehthod 2 : Update Multiple Records

    //var users = context.Users.Where(n => n.Name.StartsWith("A")).ToList();
    //foreach(var user in users)
    //{
    //    user.CreatedAT = DateTime.Now;
    //}
    //context.SaveChanges();

    //Mehthod 3 : Update using .Update() For API for example
    //we must provide existed Id 

    //var user = new User { Id = 22 , Email = "AhmedAhmed@gmail.com" };

    //context.Users.Update(user);
    //context.Entry(user).Property(e => e.Name).IsModified = false;
    //context.Entry(user).Property(e => e.CreatedAT).IsModified = false;
    //context.SaveChanges();



    ///*****************************************
    //           3 - Remove recrods
    //******************************************/



    //list<user> users = new list<user>()
    //{
    //    new user{name = "newuser1" , email = "newuser1@gmail.com" , createdat = datetime.now},
    //    new user{name = "newuser2" , email = "newuser2@gmail.com" , createdat = datetime.now},
    //    new user{name = "newuser3" , email = "newuser3@gmail.com" , createdat = datetime.now},
    //    new user{name = "newuser4" , email = "newuser4@gmail.com" , createdat = datetime.now},
    //    new user{name = "newuser5" , email = "newuser5@gmail.com" , createdat = datetime.now}
    //};
    //context.Users.AddRange(users);
    //context.SaveChanges();
    //var deletedUsers = context.Users.Where(u => u.Id > 5).ToList();
    //context.Users.RemoveRange(deletedUsers);
    //context.SaveChanges();

    //Note here the user with Id = 1 assgined to another table (Posts for example)
    // so it will throw a exception
    //var deletedUserRelatedToAnotherTable = context.Users.First(x => x.Id == 1);
    //context.Users.Remove(deletedUserRelatedToAnotherTable);
    //context.SaveChanges();



    ///*****************************************
    //           4 - Joins
    //******************************************/
    //1 - Inner Join
    //var InnerJoinQuery = from u in context.Users
    //                     join p in context.Posts
    //                     on u.Id equals p.UserId
    //                     select new
    //                     {

    //                         PostTitle = p.Title,
    //                         PostContent = p.Content,
    //                         PostId = p.Id,
    //                         UserId = u.Id
    //                     };
    //foreach (var item in InnerJoinQuery)
    //{
    //    Console.WriteLine($"Post Title = {item.PostTitle} , Post Content = {item.PostContent} , Post Id = {item.PostId} , UserId ={item.UserId}");
    //}


    //2- Left Join
    //var LeftJoinQuery = from u in context.Users
    //                    join p in context.Posts
    //                    on u.Id equals p.Id into UserPosts
    //                    from p in UserPosts.DefaultIfEmpty()
    //                    select new
    //                    {
    //                        PostTitle = p != null ? p.Title : "No Posts for this user",
    //                        UserName = u.Name
    //                    };
    //foreach (var item in LeftJoinQuery)
    //{
    //    Console.WriteLine($"UserName = {item.UserName} , Post Title = {item.PostTitle} ");
    //}

    //3-Join MultipleTables

    //var MultipleJoinUserPostCategoryQuery = from p in context.Posts
    //                                        join u in context.Users
    //                                        on p.UserId equals u.Id
    //                                        join c in context.Categories
    //                                        on p.CategoryId equals c.Id
    //                                        select new
    //                                        {
    //                                            UserName = u.Name,
    //                                            PostTitle = p.Title,
    //                                            CategoryName = c.Name
    //                                        };
    //foreach (var item in MultipleJoinUserPostCategoryQuery)
    //{
    //    Console.WriteLine($"UserName = {item.UserName} , Post Title = {item.PostTitle}  , CategoryName = {item.CategoryName}");
    //}

    //4- Cross Join
    //var query = from user in context.Users
    //            from category in context.Categories
    //            select new
    //            {
    //                UserName = user.Name,
    //                CategoryName = category.Name
    //            };

    //foreach (var result in query)
    //{
    //    Console.WriteLine($"User: {result.UserName}, Category: {result.CategoryName}");
    //}

    //

    //5-Filtering Results After a Join
    //var UserPostsFilterQuery = from u in context.Users
    //                           join p in context.Posts
    //                           on u.Id equals p.UserId
    //                           where u.Id > 2
    //                           select new
    //                           {
    //                               UserName = u.Name,
    //                               PostTitle = p.Title
    //                           };
    //foreach (var result in UserPostsFilterQuery)
    //{
    //   Console.WriteLine($"User: {result.UserName}, PostTitle: {result.PostTitle}");
    //}

    //6-grouping after joining tables
    //note : Posts in select new {} is a Ienuramble
    //it is grouped by categories
    //var GroupedQuery = from c in context.Categories
    //                   join p in context.Posts
    //                   on c.Id equals p.CategoryId into CategoryPosts
    //                   select new
    //                   {
    //                       CategoryName = c.Name,
    //                       Posts = CategoryPosts
    //                   };
    //foreach(var cat in GroupedQuery)
    //{
    //    Console.WriteLine($"category name = {cat.CategoryName}");
    //    foreach(var post in cat.Posts)
    //    {
    //        Console.WriteLine($"{post.Title}");
    //    }
    //}




}