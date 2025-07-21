-- Update users puis (ID=21) and puls (ID=30) from Manager (roleId=2) to Admin (roleId=1)
-- Execute this script on the remote PostgreSQL database

BEGIN;

-- Show current role assignments before update
SELECT 'BEFORE UPDATE:' as status, "Id", "Username", "Email", "RoleId" 
FROM "Users" 
WHERE "Id" IN (21, 30);

-- Update user 'puis' (ID 21) to Admin role
UPDATE "Users" 
SET "RoleId" = 1
WHERE "Id" = 21 AND "Username" = 'puis';

-- Update user 'puls' (ID 30) to Admin role  
UPDATE "Users"
SET "RoleId" = 1
WHERE "Id" = 30 AND "Username" = 'puls';

-- Show updated role assignments
SELECT 'AFTER UPDATE:' as status, "Id", "Username", "Email", "RoleId" 
FROM "Users" 
WHERE "Id" IN (21, 30);

-- Show all roles for reference
SELECT 'ROLES REFERENCE:' as info, "Id" as role_id, "Name" as role_name, "Description"
FROM "Roles"
ORDER BY "Id";

COMMIT;
