-- Manual migration to add BranchId column to Users table
-- This allows users to be directly associated with a branch

-- Add BranchId column to Users table (nullable to allow existing users)
ALTER TABLE "Users" 
ADD COLUMN "BranchId" integer NULL;

-- Add foreign key constraint to reference Branches table (using lowercase 'id')
ALTER TABLE "Users"
ADD CONSTRAINT "FK_Users_Branches_BranchId" 
FOREIGN KEY ("BranchId") REFERENCES "Branches"(id) ON DELETE SET NULL;

-- Add index for better query performance
CREATE INDEX "IX_Users_BranchId" ON "Users"("BranchId");

-- Add a comment for documentation
COMMENT ON COLUMN "Users"."BranchId" IS 'Foreign key reference to the branch this user belongs to'; 