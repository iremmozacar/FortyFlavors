ROUTINE_NAME,ROUTINE_DEFINITION
GetUserOrderCount,"CREATE FUNCTION dbo.GetUserOrderCount
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @OrderCount INT;

    SELECT @OrderCount = COUNT(o.Id)
    FROM Orders o
    WHERE o.UserId = @UserId;

    RETURN @OrderCount;
END;"
GetLikeCountByProductId,"CREATE FUNCTION dbo.GetLikeCountByProductId
(
    @ProductId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @LikeCount INT;

    SELECT @LikeCount = COUNT(l.Id)
    FROM Likes l
    WHERE l.ProductId = @ProductId;

    RETURN @LikeCount;
END;"
GetCategoryProductCount,"CREATE FUNCTION dbo.GetCategoryProductCount
(
    @CategoryId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @ProductCount INT;

    SELECT @ProductCount = COUNT(p.Id)
    FROM Products p
    WHERE p.CategoryId = @CategoryId;

    RETURN @ProductCount;
END;"
CalculateTotalOrderPrice,"CREATE FUNCTION dbo.CalculateTotalOrderPrice
(
    @OrderId UNIQUEIDENTIFIER
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalPrice DECIMAL(18, 2);

    SELECT @TotalPrice = ISNULL(SUM(oi.Quantity * oi.UnitPrice), 0)
    FROM OrderItems oi
    WHERE oi.OrderId = @OrderId;

    RETURN @TotalPrice;
END;"
GetCampaignActiveStatus,"CREATE FUNCTION dbo.GetCampaignActiveStatus
(
    @CampaignId UNIQUEIDENTIFIER
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsActive BIT;

    SELECT @IsActive = CASE 
        WHEN GETDATE() BETWEEN c.StartDate AND c.EndDate THEN 1
        ELSE 0
    END
    FROM Campaigns c
    WHERE c.Id = @CampaignId;

    RETURN @IsActive;
END;"
GetUserTotalSpent,"CREATE FUNCTION dbo.GetUserTotalSpent
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalSpent DECIMAL(18, 2);

    SELECT @TotalSpent = ISNULL(SUM(o.TotalAmount), 0)
    FROM Orders o
    WHERE o.UserId = @UserId;

    RETURN @TotalSpent;
END;"
GetBusinessProductCount,"CREATE FUNCTION dbo.GetBusinessProductCount
(
    @BusinessId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @ProductCount INT;

    SELECT @ProductCount = COUNT(p.Id)
    FROM Products p
    WHERE p.BusinessId = @BusinessId;

    RETURN @ProductCount;
END;"
GetTransactionSuccessRate,"CREATE FUNCTION dbo.GetTransactionSuccessRate
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @SuccessRate FLOAT;

    SELECT @SuccessRate = 
        CAST(SUM(CASE WHEN t.TransactionType = 'Success' THEN 1 ELSE 0 END) AS FLOAT) /
        CAST(COUNT(t.Id) AS FLOAT)
    FROM Transactions t
    WHERE t.UserId = @UserId;

    RETURN ISNULL(@SuccessRate, 0);
END;"
GetProductAverageRatingF,"CREATE FUNCTION dbo.GetProductAverageRatingF
(
    @ProductId UNIQUEIDENTIFIER
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @AverageRating FLOAT;

    SELECT @AverageRating = ISNULL(AVG(r.Rating), 0)
    FROM Reviews r
    WHERE r.ProductId = @ProductId;

    RETURN @AverageRating;
END;"
GetCategoryAverageRating,"CREATE FUNCTION dbo.GetCategoryAverageRating
(
    @CategoryId UNIQUEIDENTIFIER
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @AverageRating FLOAT;

    SELECT @AverageRating = ISNULL(AVG(r.Rating), 0)
    FROM Reviews r
    INNER JOIN Products p ON r.ProductId = p.Id
    WHERE p.CategoryId = @CategoryId;

    RETURN @AverageRating;
END;"
GetUserTransactionCount,"CREATE FUNCTION dbo.GetUserTransactionCount
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @TransactionCount INT;

    SELECT @TransactionCount = COUNT(t.Id)
    FROM Transactions t
    WHERE t.UserId = @UserId;

    RETURN @TransactionCount;
END;"
GetProductOrderCount,"CREATE FUNCTION dbo.GetProductOrderCount
(
    @ProductId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @OrderCount INT;

    SELECT @OrderCount = COUNT(oi.Id)
    FROM OrderItems oi
    WHERE oi.ProductId = @ProductId;

    RETURN @OrderCount;
END;"
GetBusinessCampaignCount,"CREATE FUNCTION dbo.GetBusinessCampaignCount
(
    @BusinessId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @CampaignCount INT;

    SELECT @CampaignCount = COUNT(c.Id)
    FROM Campaigns c
    WHERE c.BusinessId = @BusinessId;

    RETURN @CampaignCount;
END;"
GetUserLikesCount,"CREATE FUNCTION dbo.GetUserLikesCount
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @LikesCount INT;

    SELECT @LikesCount = COUNT(l.Id)
    FROM Likes l
    WHERE l.UserId = @UserId;

    RETURN @LikesCount;
END;"
GetOrderTotalItemCount,"CREATE FUNCTION dbo.GetOrderTotalItemCount
(
    @OrderId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @ItemCount INT;

    SELECT @ItemCount = SUM(oi.Quantity)
    FROM OrderItems oi
    WHERE oi.OrderId = @OrderId;

    RETURN @ItemCount;
END;"
GetTransactionTotalAmount,"CREATE FUNCTION dbo.GetTransactionTotalAmount
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalAmount DECIMAL(18, 2);

    SELECT @TotalAmount = ISNULL(SUM(t.Amount), 0)
    FROM Transactions t
    WHERE t.UserId = @UserId;

    RETURN @TotalAmount;
END;"
GetProductReviewCount,"CREATE FUNCTION dbo.GetProductReviewCount
(
    @ProductId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @ReviewCount INT;

    SELECT @ReviewCount = COUNT(r.Id)
    FROM Reviews r
    WHERE r.ProductId = @ProductId;

    RETURN @ReviewCount;
END;"
GetAverageTransactionAmount,"CREATE FUNCTION dbo.GetAverageTransactionAmount()
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @AverageAmount DECIMAL(18, 2);

    SELECT @AverageAmount = ISNULL(AVG(t.Amount), 0)
    FROM Transactions t;

    RETURN @AverageAmount;
END;"
GetTotalOrderItems,"CREATE FUNCTION dbo.GetTotalOrderItems
(
    @OrderId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalItems INT;

    SELECT @TotalItems = SUM(oi.Quantity)
    FROM OrderItems oi
    WHERE oi.OrderId = @OrderId;

    RETURN @TotalItems;
END;"
GetCategoryTotalRevenue,"CREATE FUNCTION dbo.GetCategoryTotalRevenue
(
    @CategoryId UNIQUEIDENTIFIER
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalRevenue DECIMAL(18, 2);

    SELECT @TotalRevenue = ISNULL(SUM(oi.Quantity * oi.UnitPrice), 0)
    FROM Products p
    INNER JOIN OrderItems oi ON p.Id = oi.ProductId
    WHERE p.CategoryId = @CategoryId;

    RETURN @TotalRevenue;
END;"
GetUserLastTransactionDate,"CREATE FUNCTION dbo.GetUserLastTransactionDate
(
    @UserId UNIQUEIDENTIFIER
)
RETURNS DATETIME
AS
BEGIN
    DECLARE @LastTransactionDate DATETIME;

    SELECT @LastTransactionDate = MAX(t.TransactionDate)
    FROM Transactions t
    WHERE t.UserId = @UserId;

    RETURN @LastTransactionDate;
END;"
GetCategoryTotalOrders,"CREATE FUNCTION dbo.GetCategoryTotalOrders
(
    @CategoryId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalOrders INT;

    SELECT @TotalOrders = COUNT(oi.Id)
    FROM OrderItems oi
    INNER JOIN Products p ON oi.ProductId = p.Id
    WHERE p.CategoryId = @CategoryId;

    RETURN @TotalOrders;
END;"
GetBusinessOrderCount,"CREATE   FUNCTION dbo.GetBusinessOrderCount
(
    @BusinessId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @OrderCount INT;

    SELECT @OrderCount = COUNT(o.Id)
    FROM Orders o
    INNER JOIN Businesses b ON b.Id = o.Id -- Orders ile Businesses arasındaki ilişkiyi kontrol edin
    WHERE b.Id = @BusinessId;

    RETURN @OrderCount;
END;"
GetBusinessTotalCampaigns,"CREATE FUNCTION dbo.GetBusinessTotalCampaigns
(
    @BusinessId UNIQUEIDENTIFIER
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalCampaigns INT;

    SELECT @TotalCampaigns = COUNT(*)
    FROM Campaigns
    WHERE BusinessId = @BusinessId;

    RETURN @TotalCampaigns;
END;"
GetAverageRatingByBusiness,"CREATE FUNCTION dbo.GetAverageRatingByBusiness
(
    @BusinessId UNIQUEIDENTIFIER
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @AverageRating FLOAT;

    SELECT @AverageRating = ISNULL(AVG(r.Rating), 0)
    FROM Reviews r
    INNER JOIN Products p ON r.ProductId = p.Id
    WHERE p.BusinessId = @BusinessId;

    RETURN @AverageRating;
END;"
