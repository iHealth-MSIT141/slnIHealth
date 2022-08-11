# iHealth健康生活專案
含網頁及資料庫，以ASP.NET Core MVC架構，網頁分為管理專區與會員頁面
![image](https://github.com/iHealth-MSIT141/slnIHealth/blob/master/homepage.jpg)
![image](https://github.com/iHealth-MSIT141/slnIHealth/blob/master/adminpage.jpg)
#### 最後更新版本 
2022/08/09
* TEDD計算器及食物列表排版修正  
* 修正會員相片無法變更問題  
* 客服回覆選項文字變更  
#### 管理專區  
放置於slnIHealth/prjIHealth/Areas/Admin/  
###### Controller及View
1.AdminController.cs          管理者及PowerBi相關(共2個View)  
2.AuthoritiesController.cs    權限相關(共5個View)  
3.CoachManageController.cs    教練履歷及評價審核相關(共2個View)  
4.MemberManageController.cs   會員管理相關(共5個View)  
5.NewsManageController.cs     健康專欄管理相關(共4個View)  
6.OrderManageController.cs    訂單管理相關(共4個View)  
7.ProductManageController.cs  產品管理相關(共4個View)  
8.ReplyController.cs          客服回覆相關(共2個View)  
#### 會員頁面
放置於slnIHealth/prjIHealth/
###### Controller及View
1.BodyController.cs     身體計算器相關(共3個View)   
2.CoachController.cs    成為教練及排定課程相關(共4個View)  
3.DiaryController.cs    飲食日誌相關(共1個View)  
4.HomeController.cs     會員登入及聊天室相關(共4個View)  
5.MemberController.cs   會員專區功能相關(共8個View)  
6.NewsController.cs     健康專欄相關(共4個View)  
7.ProblemController.cs  客服相關(共2個View)  
8.ShoppingController.cs 商城及結帳相關(共4個View)  
9.StudentController.cs 候選教練及教練評價相關(共5個View)  
#### 限制
1.客服機器人將於2022/09/05,AZURE Pass到期後失效  
2.部屬於AZURE之網頁將於2022/09/01,AZURE Pass到期後失效  
