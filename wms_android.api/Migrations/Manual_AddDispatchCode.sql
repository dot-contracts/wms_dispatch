-- Manual migration to add DispatchCode column to Dispatches table
-- This avoids Entity Framework seeded data conflicts

ALTER TABLE "Dispatches" 
ADD COLUMN "DispatchCode" text NULL;

-- Add a comment for documentation
COMMENT ON COLUMN "Dispatches"."DispatchCode" IS 'Custom dispatch code in format [DEST_CODE]-[YYYYMMDD]-DS[RANDOM]'; 