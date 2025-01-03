ROUTINE_NAME,ROUTINE_DEFINITION
GetUsersByRole,"CREATE PROCEDURE dbo.GetUsersByRole
    @RoleName NVARCHAR(50)
AS
BEGIN
    SELECT u.Id, u.Name, u.Email, r.RoleName
    FROM Users u
    INNER JOIN UserRoles r ON u.Role = r.RoleName
    WHERE r.RoleName = @RoleName;
END;"
GetProductsByCategory,"CREATE PROCEDURE dbo.GetProductsByCategory
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT p.Id, p.Name, p.Description, p.Price, p.Stock
    FROM Products p
    WHERE p.CategoryId = @CategoryId;
END;"
GetActiveCampaigns,"CREATE PROCEDURE dbo.GetActiveCampaigns
AS
BEGIN
    SELECT c.Id, c.Title, c.Description, c.StartDate, c.EndDate, c.DiscountRate
    FROM Campaigns c
    WHERE GETDATE() BETWEEN c.StartDate AND c.EndDate;
END;"
GetOrdersByDateRange,"CREATE PROCEDURE dbo.GetOrdersByDateRange
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT o.Id, o.OrderDate, o.TotalAmount, o.Status, u.Name AS UserName
    FROM Orders o
    INNER JOIN Users u ON o.UserId = u.Id
    WHERE o.OrderDate BETWEEN @StartDate AND @EndDate;
END;"
GetProductAverageRating,"CREATE PROCEDURE dbo.GetProductAverageRating
    @ProductId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT p.Id, p.Name,
           ISNULL(AVG(r.Rating), 0) AS AverageRating
    FROM Products p
    LEFT JOIN Reviews r ON p.Id = r.ProductId
    WHERE p.Id = @ProductId
    GROUP BY p.Id, p.Name;
END;"
GetUserOrderStats,"CREATE PROCEDURE dbo.GetUserOrderStats
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT u.Id, u.Name, 
           COUNT(o.Id) AS TotalOrders,
           ISNULL(SUM(o.TotalAmount), 0) AS TotalSpent
    FROM Users u
    LEFT JOIN Orders o ON u.Id = o.UserId
    WHERE u.Id = @UserId
    GROUP BY u.Id, u.Name;
END;"
GetOrdersByUser,"CREATE PROCEDURE dbo.GetOrdersByUser
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status
    FROM Orders o
    WHERE o.UserId = @UserId;
END;"
GetTopSellingProducts,"CREATE PROCEDURE dbo.GetTopSellingProducts
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount) 
        p.Id AS ProductId,
        p.Name AS ProductName,
        COUNT(oi.Id) AS TotalSold,
        ISNULL(SUM(oi.Quantity * oi.UnitPrice), 0) AS TotalRevenue
    FROM Products p
    LEFT JOIN OrderItems oi ON p.Id = oi.ProductId
    GROUP BY p.Id, p.Name
    ORDER BY TotalSold DESC;
END;"
GetCampaignPerformance,"CREATE PROCEDURE dbo.GetCampaignPerformance
    @CampaignId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CampaignId,
        c.Title,
        c.DiscountRate
    FROM Campaigns c
    WHERE c.Id = @CampaignId;
END;"
GetBusinessesByCategory,"CREATE PROCEDURE dbo.GetBusinessesByCategory
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        b.Id AS BusinessId,
        b.Name AS BusinessName,
        b.Address,
        b.PhoneNumber,
        b.Email
    FROM Businesses b
    WHERE b.CategoryId = @CategoryId;
END;"
GetProductsByBusiness,"CREATE PROCEDURE dbo.GetProductsByBusiness
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        p.Id AS ProductId,
        p.Name AS ProductName,
        p.Description,
        p.Price,
        p.Stock
    FROM Products p
    WHERE p.BusinessId = @BusinessId;
END;"
GetUserOrderHistory,"CREATE PROCEDURE dbo.GetUserOrderHistory
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status
    FROM Orders o
    WHERE o.UserId = @UserId;
END;"
GetCategoryPerformance,"CREATE PROCEDURE dbo.GetCategoryPerformance
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CategoryId,
        c.Name AS CategoryName,
        COUNT(p.Id) AS TotalProducts,
        ISNULL(SUM(oi.Quantity * oi.UnitPrice), 0) AS TotalRevenue
    FROM Categories c
    LEFT JOIN Products p ON c.Id = p.CategoryId
    LEFT JOIN OrderItems oi ON p.Id = oi.ProductId
    WHERE c.Id = @CategoryId
    GROUP BY c.Id, c.Name;
END;"
GetTopRatedProducts,"CREATE PROCEDURE dbo.GetTopRatedProducts
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        p.Id AS ProductId,
        p.Name AS ProductName,
        ISNULL(AVG(r.Rating), 0) AS AverageRating
    FROM Products p
    LEFT JOIN Reviews r ON p.Id = r.ProductId
    GROUP BY p.Id, p.Name
    ORDER BY AverageRating DESC;
END;"
GetCampaignsByBusiness,"CREATE PROCEDURE dbo.GetCampaignsByBusiness
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CampaignId,
        c.Title,
        c.Description,
        c.StartDate,
        c.EndDate,
        c.DiscountRate
    FROM Campaigns c
    WHERE c.BusinessId = @BusinessId;
END;"
GetUserMessages,"CREATE PROCEDURE dbo.GetUserMessages
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        m.Id AS MessageId,
        m.Subject,
        m.Content,
        m.SentDate,
        m.IsRead
    FROM Messages m
    WHERE m.ReceiverId = @UserId
    ORDER BY m.SentDate DESC;
END;"
GetPendingOrders,"CREATE PROCEDURE dbo.GetPendingOrders
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status,
        u.Name AS CustomerName
    FROM Orders o
    INNER JOIN Users u ON o.UserId = u.Id
    WHERE o.Status = 'Pending';
END;"
GetTransactionDetails,"CREATE PROCEDURE dbo.GetTransactionDetails
    @TransactionId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        t.Id AS TransactionId,
        t.Amount,
        t.TransactionType,
        t.TransactionDate,
        t.ReferenceNumber,
        t.TrackingNumber
    FROM Transactions t
    WHERE t.Id = @TransactionId;
END;"
GetProductDetails,"CREATE PROCEDURE dbo.GetProductDetails
    @ProductId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        p.Id AS ProductId,
        p.Name AS ProductName,
        p.Description,
        p.Price,
        p.Stock,
        b.Name AS BusinessName,
        c.Name AS CategoryName
    FROM Products p
    INNER JOIN Businesses b ON p.BusinessId = b.Id
    INNER JOIN Categories c ON p.CategoryId = c.Id
    WHERE p.Id = @ProductId;
END;"
GetOrderDetails,"CREATE PROCEDURE dbo.GetOrderDetails
    @OrderId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status,
        oi.ProductId,
        oi.ProductName,
        oi.Quantity,
        oi.UnitPrice,
        (oi.Quantity * oi.UnitPrice) AS TotalPrice
    FROM Orders o
    INNER JOIN OrderItems oi ON o.Id = oi.OrderId
    WHERE o.Id = @OrderId;
END;"
GetUserReviews,"CREATE PROCEDURE dbo.GetUserReviews
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        r.Id AS ReviewId,
        r.Comment,
        r.Rating,
        p.Name AS ProductName,
        r.ProductId
    FROM Reviews r
    INNER JOIN Products p ON r.ProductId = p.Id
    WHERE r.UserId = @UserId;
END;"
GetBusinessTransactions,"CREATE PROCEDURE dbo.GetBusinessTransactions
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        t.Id AS TransactionId,
        t.TransactionDate,
        t.Amount,
        t.TransactionType,
        t.ReferenceNumber
    FROM Transactions t
    INNER JOIN Products p ON t.UserId = p.BusinessId
    WHERE p.BusinessId = @BusinessId;
END;"
GetPopularProducts,"CREATE PROCEDURE dbo.GetPopularProducts
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        p.Id AS ProductId,
        p.Name AS ProductName,
        COUNT(oi.Id) AS TotalOrders
    FROM Products p
    INNER JOIN OrderItems oi ON p.Id = oi.ProductId
    GROUP BY p.Id, p.Name
    ORDER BY TotalOrders DESC;
END;"
GetProductLikes,"CREATE PROCEDURE dbo.GetProductLikes
    @ProductId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        l.Id AS LikeId,
        l.UserId,
        l.CreatedAt
    FROM Likes l
    WHERE l.ProductId = @ProductId;
END;"
GetPendingPayments,"CREATE PROCEDURE dbo.GetPendingPayments
AS
BEGIN
    SELECT 
        p.Id AS PaymentId,
        p.OrderId,
        p.Amount,
        p.PaymentStatus,
        p.PaymentDate
    FROM Payments p
    WHERE p.PaymentStatus = 'Pending';
END;"
GetBusinessCampaignDetails,"CREATE PROCEDURE dbo.GetBusinessCampaignDetails
    @CampaignId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CampaignId,
        c.Title,
        c.Description,
        c.StartDate,
        c.EndDate,
        c.DiscountRate,
        b.Name AS BusinessName
    FROM Campaigns c
    INNER JOIN Businesses b ON c.BusinessId = b.Id
    WHERE c.Id = @CampaignId;
END;"
GetUserRoles,"CREATE PROCEDURE dbo.GetUserRoles
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        ur.Id AS UserRoleId,
        ur.RoleName
    FROM UserRoles ur
    INNER JOIN Users u ON ur.Id = u.Role
    WHERE u.Id = @UserId;
END;"
GetMessagesByBusiness,"CREATE PROCEDURE dbo.GetMessagesByBusiness
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        m.Id AS MessageId,
        m.Subject,
        m.Content,
        m.SentDate,
        m.IsRead,
        m.SenderId
    FROM Messages m
    WHERE m.ReceiverId = @BusinessId;
END;"
GetRevenueByDateRange,"CREATE PROCEDURE dbo.GetRevenueByDateRange
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        SUM(o.TotalAmount) AS TotalRevenue,
        COUNT(o.Id) AS TotalOrders
    FROM Orders o
    WHERE o.OrderDate BETWEEN @StartDate AND @EndDate;
END;"
GetOrdersByStatus,"CREATE PROCEDURE dbo.GetOrdersByStatus
    @Status NVARCHAR(50)
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status,
        u.Name AS UserName
    FROM Orders o
    INNER JOIN Users u ON o.UserId = u.Id
    WHERE o.Status = @Status;
END;"
GetUserLikedProducts,"CREATE PROCEDURE dbo.GetUserLikedProducts
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        p.Id AS ProductId,
        p.Name AS ProductName,
        l.CreatedAt AS LikedDate
    FROM Likes l
    INNER JOIN Products p ON l.ProductId = p.Id
    WHERE l.UserId = @UserId;
END;"
GetProductComments,"CREATE PROCEDURE dbo.GetProductComments
    @ProductId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CommentId,
        c.Content AS CommentText,
        c.CreatedAt,
        u.Name AS UserName
    FROM Comments c
    INNER JOIN Users u ON c.UserId = u.Id
    WHERE c.ProductId = @ProductId;
END;"
GetCategoryProducts,"CREATE PROCEDURE dbo.GetCategoryProducts
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        p.Id AS ProductId,
        p.Name AS ProductName,
        p.Price,
        p.Stock
    FROM Products p
    WHERE p.CategoryId = @CategoryId;
END;"
GetUserTransactionHistory,"CREATE PROCEDURE dbo.GetUserTransactionHistory
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        t.Id AS TransactionId,
        t.Amount,
        t.TransactionType,
        t.TransactionDate,
        t.ReferenceNumber,
        t.TrackingNumber
    FROM Transactions t
    WHERE t.UserId = @UserId;
END;"
GetUserMessagesSummary,"CREATE PROCEDURE dbo.GetUserMessagesSummary
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        COUNT(CASE WHEN m.IsRead = 0 THEN 1 ELSE NULL END) AS UnreadMessages,
        COUNT(CASE WHEN m.IsRead = 1 THEN 1 ELSE NULL END) AS ReadMessages
    FROM Messages m
    WHERE m.ReceiverId = @UserId;
END;"
GetPendingTransactions,"CREATE PROCEDURE dbo.GetPendingTransactions
AS
BEGIN
    SELECT 
        t.Id AS TransactionId,
        t.UserId,
        t.Amount,
        t.TransactionDate,
        t.TransactionType,
        t.ReferenceNumber
    FROM Transactions t
    WHERE t.TransactionType = 'Pending';
END;"
GetTopCampaignsByRevenue,"CREATE   PROCEDURE dbo.GetTopCampaignsByRevenue
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        c.Id AS CampaignId,
        c.Title AS CampaignTitle,
        ISNULL(SUM(o.TotalAmount), 0) AS TotalRevenue
    FROM Campaigns c
    LEFT JOIN Orders o ON c.Id = o.Id -- Orders tablosunda CampaignId olmadığı için ilişkileri kontrol edin
    GROUP BY c.Id, c.Title
    ORDER BY TotalRevenue DESC;
END;"
GetUserProductReviews,"CREATE   PROCEDURE dbo.GetUserProductReviews
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        r.Id AS ReviewId,
        r.ProductId,
        r.Comment,
        r.Rating
    FROM Reviews r
    WHERE r.UserId = @UserId;
END;"
GetBusinessRevenue,"CREATE   PROCEDURE dbo.GetBusinessRevenue
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        b.Id AS BusinessId,
        b.Name AS BusinessName,
        ISNULL(SUM(o.TotalAmount), 0) AS TotalRevenue
    FROM Businesses b
    LEFT JOIN Orders o ON b.Id = o.Id -- Orders tablosunda BusinessId olmadığı için ilişkiyi kontrol edin
    WHERE b.Id = @BusinessId
    GROUP BY b.Id, b.Name;
END;"
GetUserLikes,"CREATE PROCEDURE dbo.GetUserLikes
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        l.Id AS LikeId,
        l.ProductId,
        p.Name AS ProductName,
        l.CreatedAt
    FROM Likes l
    INNER JOIN Products p ON l.ProductId = p.Id
    WHERE l.UserId = @UserId;
END;"
GetCategoryProductsPerformance,"CREATE PROCEDURE dbo.GetCategoryProductsPerformance
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        p.Id AS ProductId,
        p.Name AS ProductName,
        SUM(oi.Quantity) AS TotalQuantitySold,
        SUM(oi.Quantity * oi.UnitPrice) AS TotalRevenue
    FROM Products p
    INNER JOIN OrderItems oi ON p.Id = oi.ProductId
    WHERE p.CategoryId = @CategoryId
    GROUP BY p.Id, p.Name;
END;"
GetTopRatedProductsByCategory,"CREATE PROCEDURE dbo.GetTopRatedProductsByCategory
    @CategoryId UNIQUEIDENTIFIER,
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        p.Id AS ProductId,
        p.Name AS ProductName,
        AVG(r.Rating) AS AverageRating
    FROM Products p
    INNER JOIN Reviews r ON p.Id = r.ProductId
    WHERE p.CategoryId = @CategoryId
    GROUP BY p.Id, p.Name
    ORDER BY AverageRating DESC;
END;"
GetTransactionHistoryByUser,"CREATE PROCEDURE dbo.GetTransactionHistoryByUser
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        t.Id AS TransactionId,
        t.Amount,
        t.TransactionType,
        t.TransactionDate,
        t.ReferenceNumber
    FROM Transactions t
    WHERE t.UserId = @UserId;
END;"
GetBusinessCampaignPerformance,"CREATE   PROCEDURE dbo.GetBusinessCampaignPerformance
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CampaignId,
        c.Title AS CampaignTitle,
        ISNULL(SUM(o.TotalAmount), 0) AS TotalRevenue,
        COUNT(o.Id) AS TotalOrders
    FROM Campaigns c
    LEFT JOIN Orders o ON c.Id = o.Id -- Orders tablosunda CampaignId ilişkisi yoksa netleştirin
    WHERE c.BusinessId = @BusinessId
    GROUP BY c.Id, c.Title;
END;"
GetUserActivitySummary,"CREATE PROCEDURE dbo.GetUserActivitySummary
    @UserId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        (SELECT COUNT(*) FROM Orders WHERE UserId = @UserId) AS TotalOrders,
        (SELECT COUNT(*) FROM Reviews WHERE UserId = @UserId) AS TotalReviews,
        (SELECT COUNT(*) FROM Likes WHERE UserId = @UserId) AS TotalLikes
END;"
GetTopSellingProductsByCategory,"CREATE PROCEDURE dbo.GetTopSellingProductsByCategory
    @CategoryId UNIQUEIDENTIFIER,
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        p.Id AS ProductId,
        p.Name AS ProductName,
        SUM(oi.Quantity) AS TotalQuantitySold
    FROM Products p
    INNER JOIN OrderItems oi ON p.Id = oi.ProductId
    WHERE p.CategoryId = @CategoryId
    GROUP BY p.Id, p.Name
    ORDER BY TotalQuantitySold DESC;
END;"
GetUserRecentOrders,"CREATE PROCEDURE dbo.GetUserRecentOrders
    @UserId UNIQUEIDENTIFIER,
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        o.Id AS OrderId,
        o.OrderDate,
        o.TotalAmount,
        o.Status
    FROM Orders o
    WHERE o.UserId = @UserId
    ORDER BY o.OrderDate DESC;
END;"
GetMostLikedProducts,"CREATE PROCEDURE dbo.GetMostLikedProducts
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        p.Id AS ProductId,
        p.Name AS ProductName,
        COUNT(l.Id) AS TotalLikes
    FROM Likes l
    INNER JOIN Products p ON l.ProductId = p.Id
    GROUP BY p.Id, p.Name
    ORDER BY TotalLikes DESC;
END;"
GetTopActiveUsers,"CREATE PROCEDURE dbo.GetTopActiveUsers
    @TopCount INT
AS
BEGIN
    SELECT TOP (@TopCount)
        u.Id AS UserId,
        u.Name AS UserName,
        COUNT(o.Id) AS TotalOrders
    FROM Users u
    INNER JOIN Orders o ON u.Id = o.UserId
    GROUP BY u.Id, u.Name
    ORDER BY TotalOrders DESC;
END;"
GetCategoryRevenueSummary,"CREATE PROCEDURE dbo.GetCategoryRevenueSummary
    @CategoryId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        SUM(oi.Quantity * oi.UnitPrice) AS TotalRevenue,
        COUNT(oi.Id) AS TotalOrders
    FROM Products p
    INNER JOIN OrderItems oi ON p.Id = oi.ProductId
    WHERE p.CategoryId = @CategoryId;
END;"
GetMonthlyOrdersByBusiness,"CREATE   PROCEDURE dbo.GetMonthlyOrdersByBusiness
    @BusinessId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        DATEPART(MONTH, o.OrderDate) AS Month,
        COUNT(o.Id) AS TotalOrders,
        SUM(o.TotalAmount) AS TotalRevenue
    FROM Orders o
    INNER JOIN Businesses b ON o.Id = b.Id -- Eğer işletme ile sipariş arasında bir ilişki farklı şekilde kuruluyorsa netleştirin
    WHERE b.Id = @BusinessId
    GROUP BY DATEPART(MONTH, o.OrderDate)
    ORDER BY Month;
END;"
GetCampaignDetails,"CREATE PROCEDURE dbo.GetCampaignDetails
    @CampaignId UNIQUEIDENTIFIER
AS
BEGIN
    SELECT 
        c.Id AS CampaignId,
        c.Title,
        c.Description,
        c.StartDate,
        c.EndDate,
        c.DiscountRate,
        b.Name AS BusinessName
    FROM Campaigns c
    INNER JOIN Businesses b ON c.BusinessId = b.Id
    WHERE c.Id = @CampaignId;
END;"
