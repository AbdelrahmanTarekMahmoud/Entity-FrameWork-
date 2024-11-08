using EntityFramework.Data;
using EntityFramework.Model;

var context = new ApplicationDbContext();

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

List<Comment> comments = new List<Comment>()
{
    new Comment { Content = "Fantastic post on C#!", UserId = 1, PostId = 2 },
    new Comment { Content = "I really enjoyed the C++ article.", UserId = 2, PostId = 3 },
    new Comment { Content = "C is the backbone of many systems.", UserId = 3, PostId = 4 },
    new Comment { Content = "Go language is very efficient.", UserId = 4, PostId = 5 },
    new Comment { Content = "Java is versatile!", UserId = 5, PostId = 6 }
};

context.AddRange(comments);
context.SaveChanges();


