INSERT INTO Plants (Name, Type, Size, Price, Description, ListedBy, DateAdded, CareDifficulty, CareDetails)
VALUES
    ('Aloe Vera', 'Succulent', 'Small', 12.99, 'Popular succulent with medicinal properties', 2, GETDATE(), 4, 'Water sparingly, requires well-draining soil'),
    ('Jasmine', 'Flowering', 'Medium', 19.99, 'Fragrant flowers used in perfumes and teas', 3, GETDATE(), 6, 'Prefers bright indirect light and regular watering'),
    ('Moss Rose', 'Flowering', 'Small', 8.99, 'Low-growing plant with vibrant flowers', 1, GETDATE(), 3, 'Thrives in sunny locations, water moderately'),
    ('Lemon Tree', 'Edible', 'Large', 29.99, 'Produces juicy lemons', 2, GETDATE(), 7, 'Requires full sun, water deeply but infrequently'),
    ('Tillandsia', 'Air-Plant', 'Small', 6.99, 'Low-maintenance plant that does not require soil', 4, GETDATE(), 2, 'Mist regularly, bright indirect light'),
    ('Cactus', 'Succulent', 'Small', 9.99, 'Thorny desert plant that requires minimal watering', 3, GETDATE(), 3, 'Water sparingly, well-draining soil'),
    ('Orchid', 'Flowering', 'Medium', 24.99, 'Elegant flowers that come in a variety of colors', 1, GETDATE(), 5, 'Prefers indirect light, water carefully'),
    ('Bamboo', 'Air-Plant', 'Large', 39.99, 'Fast-growing plant often used for decorative purposes', 2, GETDATE(), 6, 'Requires bright light and ample watering'),
    ('Rose', 'Flowering', 'Medium', 17.99, 'Classic flower known for its beauty and fragrance', 4, GETDATE(), 8, 'Prefers full sun, prune regularly'),
    ('Chili Pepper', 'Edible', 'Small', 7.99, 'Spicy pepper used in various culinary dishes', 3, GETDATE(), 7, 'Full sun, moderate watering, well-draining soil'),
    ('Succulent Mix', 'Succulent', 'Small', 11.99, 'Assortment of different succulent varieties', 1, GETDATE(), 4, 'Water sparingly, prefers bright light'),
    ('Fiddle Leaf Fig', 'Flowering', 'Large', 49.99, 'Trendy plant with large, violin-shaped leaves', 2, 5, 'Requires bright indirect light, water when topsoil is dry', DATEADD(day, -7, GETDATE())),
    ('Strawberry Plant', 'Edible', 'Small', 6.99, 'Produces sweet and juicy strawberries', 1, 4, 'Full sun, regular watering, well-draining soil', DATEADD(day, -10, GETDATE())),
    ('Spider Plant', 'Air-Plant', 'Small', 12.99, 'Easy-to-care-for plant with arching variegated leaves', 3, 2, 'Thrives in bright indirect light, water moderately', DATEADD(day, -15, GETDATE())),
    ('Lavender', 'Flowering', 'Medium', 14.99, 'Fragrant herb with purple flowers', 4, 3, 'Prefers full sun, well-draining soil, occasional pruning', DATEADD(day, -3, GETDATE())),
    ('Money Tree', 'Flowering', 'Medium', 19.99, 'Plant with braided trunk and glossy leaves', 2, 4, 'Indirect light, water when topsoil is dry', DATEADD(day, -8, GETDATE())),
    ('Basil', 'Edible', 'Small', 6.99, 'Popular herb used in cooking and pesto', 1, 2, 'Full sun, regular watering, well-draining soil', DATEADD(day, -12, GETDATE())),
    ('Jade Plant', 'Succulent', 'Medium', 24.99, 'Thick, fleshy leaves and a tree-like appearance', 3, 6, 'Bright light, infrequent watering, well-draining soil', DATEADD(day, -5, GETDATE())),
    ('Snake Plant', 'Flowering', 'Small', 9.99, 'Low maintenance plant with upright leaves', 4, 3, 'Tolerates low light, water sparingly', DATEADD(day, -20, GETDATE())),
    ('Mint', 'Edible', 'Small', 7.99, 'Aromatic herb commonly used in beverages and desserts', 1, 2, 'Partial shade, regular watering, moist soil', DATEADD(day, -25, GETDATE())),
    ('Pothos', 'Air-Plant', 'Medium', 16.99, 'Trailing plant with heart-shaped leaves', 2, 4, 'Thrives in low to bright indirect light, water moderately', DATEADD(day, -17, GETDATE()));


INSERT INTO Users (Username, Password, IsAdmin)
VALUES ('User1', 'password1', 0),
		('User2', 'password2', 0),
		('User3', 'password3', 0),
		('Admin', 'adminpass', 1);


INSERT INTO Comments (PlantID, Comment, UserID, CommentDate)
VALUES
    (1, 'This plant is beautiful!', 2, GETDATE()),
    (3, 'Can this plant tolerate low light conditions?', 4, GETDATE()),
    (5, 'I love the taste of strawberries from this plant!', 1, GETDATE()),
    (7, 'The fragrance of lavender is so calming.', 3, GETDATE()),
    (9, 'I have been wanting to grow my own herbs, and this basil looks great!', 2, GETDATE()),
    (11, 'Is this plant safe for pets?', 4, GETDATE()),
    (13, 'Jade plants are one of my favorites!', 1, GETDATE()),
    (15, 'I have owned a snake plant for years, and it is so easy to care for.', 3, GETDATE()),
    (17, 'Mint is a must-have in my kitchen!', 2, GETDATE()),
    (19, 'Pothos plants are perfect for adding greenery to any space.', 4, GETDATE());
