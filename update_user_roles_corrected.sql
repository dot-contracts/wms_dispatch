-- Update users puis (ID=30) and Chege (ID=33) from Manager (roleId=2) to Admin (roleId=1)
-- Execute this script on the remote PostgreSQL database

BEGIN;

-- Show current role assignments before update
SELECT 'BEFORE UPDATE:' as status, "Id", "Username", "FirstName", "LastName", "Email", "RoleId" 
FROM "Users" 
WHERE "Id" IN (30, 33);

-- Update user 'puis' (ID 30) to Admin role
UPDATE "Users" 
SET "RoleId" = 1
WHERE "Id" = 30 AND "Username" = 'puis';

-- Update user 'Chege' (ID 33) to Admin role  
UPDATE "Users"
SET "RoleId" = 1
WHERE "Id" = 33 AND "Username" = 'Chege';

-- Show updated role assignments
SELECT 'AFTER UPDATE:' as status, "Id", "Username", "FirstName", "LastName", "Email", "RoleId" 
FROM "Users" 
WHERE "Id" IN (30, 33);

-- Show all roles for reference
SELECT 'ROLES REFERENCE:' as info, "Id" as role_id, "Name" as role_name, "Description"
FROM "Roles"
ORDER BY "Id";

COMMIT;
