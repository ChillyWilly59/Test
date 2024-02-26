SELECT
  p.Name AS 'Имя продукта',
  c.Name AS 'Имя категории'
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id
ORDER BY p.Name;