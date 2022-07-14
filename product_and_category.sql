select product.name, category.name
from product left join productInCategory on product.id = productInCategory.productId
left join category on category.id = productInCategory.CategoryId