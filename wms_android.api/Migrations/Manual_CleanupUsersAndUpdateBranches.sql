-- Manual migration to cleanup duplicate users and update branch assignments
-- This script will:
-- 1. Remove duplicate usernames (keeping the first occurrence by ID)
-- 2. Update branch assignments for specified users

-- Start transaction
BEGIN;

-- Step 1: Remove duplicate users (keeping the first occurrence by ID)
-- First, let's see what we're working with
SELECT 'Duplicate users before cleanup:' as info;
SELECT "Username", "Id", "CreatedAt" 
FROM "Users" 
WHERE "Username" IN (
    SELECT "Username" 
    FROM "Users" 
    GROUP BY "Username" 
    HAVING COUNT(*) > 1
) 
ORDER BY "Username", "Id";

-- Delete duplicate users, keeping only the first occurrence (lowest ID)
DELETE FROM "Users" 
WHERE "Id" NOT IN (
    SELECT MIN("Id") 
    FROM "Users" 
    GROUP BY "Username"
);

-- Step 2: Update branch assignments for specified users
-- Branch mapping based on database:
-- 1 = Nairobi, 2 = Mombasa, 3 = Kisumu, 4 = Nakuru, 5 = Kericho, 6 = Kitale, 12 = Eldoret

-- Update users with their assigned branches
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'fabiano';     -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'augustine';   -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'pwambugu';    -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'kennedy';     -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'lucy';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'simon';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'kinyua';      -- Nairobi
UPDATE "Users" SET "BranchId" = 4 WHERE "Username" = 'nelson';      -- Nakuru
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'ababu';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'kevin';       -- Nairobi
UPDATE "Users" SET "BranchId" = 4 WHERE "Username" = 'joseph';      -- Nakuru
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'pauline';     -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'puis';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'paul';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'ben';         -- Nairobi

-- Note: Looking for 'Chege' but it might be stored differently in the database
-- Let's try to find it first
UPDATE "Users" SET "BranchId" = 1 WHERE LOWER("Username") = 'chege' OR "Username" = 'Chege';  -- Nairobi

UPDATE "Users" SET "BranchId" = 12 WHERE "Username" = 'sammy';       -- Eldoret
UPDATE "Users" SET "BranchId" = 5 WHERE "Username" = 'fridah';       -- Kericho
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'tuti';         -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'braxtone';     -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'dennis';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'alex';         -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'lewis';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'joash';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'titus';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'esther';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'edwin';        -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'simiyu';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'bravine';      -- Nairobi
UPDATE "Users" SET "BranchId" = 4 WHERE "Username" = 'saningo';      -- Nakuru
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'kihara';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'joe';          -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'ilova';        -- Nairobi
UPDATE "Users" SET "BranchId" = 3 WHERE "Username" = 'wandiga';      -- Kisumu
UPDATE "Users" SET "BranchId" = 6 WHERE "Username" = 'jeff';         -- Kitale
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'kiarie';       -- Nairobi
UPDATE "Users" SET "BranchId" = 1 WHERE "Username" = 'maina';        -- Nairobi

-- Step 3: Verification - Show the results
SELECT 'Users after cleanup and branch assignment:' as info;
SELECT 
    u."Id", 
    u."Username", 
    u."FirstName", 
    u."LastName", 
    u."BranchId",
    b.name as branch_name
FROM "Users" u
LEFT JOIN "Branches" b ON u."BranchId" = b.id
WHERE u."Username" IN (
    'fabiano', 'augustine', 'pwambugu', 'kennedy', 'lucy', 'simon', 'kinyua', 
    'nelson', 'ababu', 'kevin', 'joseph', 'pauline', 'puis', 'paul', 'ben', 
    'chege', 'sammy', 'fridah', 'tuti', 'braxtone', 'dennis', 'alex', 'lewis', 
    'joash', 'titus', 'esther', 'edwin', 'simiyu', 'bravine', 'saningo', 
    'kihara', 'joe', 'ilova', 'wandiga', 'jeff', 'kiarie', 'maina'
)
ORDER BY u."Id";

-- Check for any duplicate usernames remaining
SELECT 'Remaining duplicate usernames:' as info;
SELECT "Username", COUNT(*) as count 
FROM "Users" 
GROUP BY "Username" 
HAVING COUNT(*) > 1 
ORDER BY count DESC, "Username";

-- Commit the transaction
COMMIT; 