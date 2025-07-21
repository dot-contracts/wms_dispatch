-- Update users puis (ID=21) and puls (ID=30) from Manager (roleId=2) to Admin (roleId=1)

-- Update user 'puis' (ID 21) to Admin role
UPDATE "Users" 
SET "RoleId" = 1
WHERE "Id" = 21 AND "Username" = 'puis';

-- Update user 'puls' (ID 30) to Admin role  
UPDATE "Users"
SET "RoleId" = 1
WHERE "Id" = 30 AND "Username" = 'puls';

-- Verify the changes
SELECT "Id", "Username", "Email", "RoleId" 
FROM "Users" 
WHERE "Id" IN (21, 30);
