-- Invoicing System Migration Script
-- This script adds the necessary tables for the contract customer invoicing system
-- Run this script on the remote database used by the .NET API

-- Create ContractCustomers table
CREATE TABLE IF NOT EXISTS "ContractCustomers" (
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(200) NOT NULL,
    "CompanyName" VARCHAR(200) NULL,
    "Email" VARCHAR(100) NULL,
    "Phone" VARCHAR(20) NULL,
    "Address" VARCHAR(500) NULL,
    "ContactPerson" VARCHAR(100) NULL,
    "ContractNumber" VARCHAR(50) NULL,
    "PaymentTerms" VARCHAR(100) NOT NULL DEFAULT 'Net 30',
    "TaxRate" DECIMAL(5,2) NOT NULL DEFAULT 0.00,
    "IsActive" BOOLEAN NOT NULL DEFAULT TRUE,
    "CreatedAt" TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT NOW(),
    "UpdatedAt" TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT NOW(),
    "CreatedById" INTEGER NOT NULL,
    CONSTRAINT "FK_ContractCustomers_Users_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "Users" ("Id") ON DELETE RESTRICT
);

-- Create Invoices table
CREATE TABLE IF NOT EXISTS "Invoices" (
    "Id" SERIAL PRIMARY KEY,
    "InvoiceNumber" VARCHAR(50) NOT NULL UNIQUE,
    "CustomerId" INTEGER NOT NULL,
    "IssueDate" DATE NOT NULL,
    "DueDate" DATE NOT NULL,
    "Status" VARCHAR(20) NOT NULL DEFAULT 'draft',
    "Subtotal" DECIMAL(12,2) NOT NULL DEFAULT 0.00,
    "TaxAmount" DECIMAL(12,2) NOT NULL DEFAULT 0.00,
    "TotalAmount" DECIMAL(12,2) NOT NULL DEFAULT 0.00,
    "Notes" VARCHAR(1000) NULL,
    "CreatedById" INTEGER NOT NULL,
    "CreatedAt" TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT NOW(),
    "UpdatedAt" TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT NOW(),
    CONSTRAINT "FK_Invoices_ContractCustomers_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES "ContractCustomers" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_Invoices_Users_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "Users" ("Id") ON DELETE RESTRICT
);

-- Create InvoiceItems table
CREATE TABLE IF NOT EXISTS "InvoiceItems" (
    "Id" SERIAL PRIMARY KEY,
    "InvoiceId" INTEGER NOT NULL,
    "ParcelId" VARCHAR(100) NOT NULL,
    "WaybillNumber" VARCHAR(50) NOT NULL,
    "Description" VARCHAR(200) NOT NULL,
    "Quantity" INTEGER NOT NULL DEFAULT 1,
    "UnitPrice" DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    "TotalPrice" DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    "CreatedAt" TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT NOW(),
    CONSTRAINT "FK_InvoiceItems_Invoices_InvoiceId" FOREIGN KEY ("InvoiceId") REFERENCES "Invoices" ("Id") ON DELETE CASCADE
);

-- Create indexes for better performance
CREATE INDEX IF NOT EXISTS "IX_ContractCustomers_CreatedById" ON "ContractCustomers" ("CreatedById");
CREATE INDEX IF NOT EXISTS "IX_ContractCustomers_IsActive" ON "ContractCustomers" ("IsActive");
CREATE INDEX IF NOT EXISTS "IX_Invoices_CustomerId" ON "Invoices" ("CustomerId");
CREATE INDEX IF NOT EXISTS "IX_Invoices_CreatedById" ON "Invoices" ("CreatedById");
CREATE INDEX IF NOT EXISTS "IX_Invoices_Status" ON "Invoices" ("Status");
CREATE INDEX IF NOT EXISTS "IX_Invoices_IssueDate" ON "Invoices" ("IssueDate");
CREATE INDEX IF NOT EXISTS "IX_InvoiceItems_InvoiceId" ON "InvoiceItems" ("InvoiceId");
CREATE INDEX IF NOT EXISTS "IX_InvoiceItems_ParcelId" ON "InvoiceItems" ("ParcelId");
CREATE INDEX IF NOT EXISTS "IX_InvoiceItems_WaybillNumber" ON "InvoiceItems" ("WaybillNumber");

-- Create unique constraint to prevent duplicate parcels in the same invoice
CREATE UNIQUE INDEX IF NOT EXISTS "IX_InvoiceItems_InvoiceId_ParcelId" ON "InvoiceItems" ("InvoiceId", "ParcelId");

-- Add comments for documentation
COMMENT ON TABLE "ContractCustomers" IS 'Stores contract customers for invoicing';
COMMENT ON TABLE "Invoices" IS 'Stores invoices for contract customers';
COMMENT ON TABLE "InvoiceItems" IS 'Stores individual parcels/items in invoices';

COMMENT ON COLUMN "ContractCustomers"."Name" IS 'Customer name';
COMMENT ON COLUMN "ContractCustomers"."CompanyName" IS 'Company name (optional)';
COMMENT ON COLUMN "ContractCustomers"."Email" IS 'Customer email address';
COMMENT ON COLUMN "ContractCustomers"."Phone" IS 'Customer phone number';
COMMENT ON COLUMN "ContractCustomers"."Address" IS 'Customer address';
COMMENT ON COLUMN "ContractCustomers"."ContactPerson" IS 'Primary contact person';
COMMENT ON COLUMN "ContractCustomers"."ContractNumber" IS 'Contract reference number';
COMMENT ON COLUMN "ContractCustomers"."PaymentTerms" IS 'Payment terms (e.g., Net 30)';
COMMENT ON COLUMN "ContractCustomers"."TaxRate" IS 'Tax rate percentage';
COMMENT ON COLUMN "ContractCustomers"."IsActive" IS 'Whether the customer is active';

COMMENT ON COLUMN "Invoices"."InvoiceNumber" IS 'Unique invoice number';
COMMENT ON COLUMN "Invoices"."CustomerId" IS 'Reference to contract customer';
COMMENT ON COLUMN "Invoices"."IssueDate" IS 'Date invoice was issued';
COMMENT ON COLUMN "Invoices"."DueDate" IS 'Date payment is due';
COMMENT ON COLUMN "Invoices"."Status" IS 'Invoice status (draft, sent, paid, overdue, cancelled)';
COMMENT ON COLUMN "Invoices"."Subtotal" IS 'Subtotal before tax';
COMMENT ON COLUMN "Invoices"."TaxAmount" IS 'Tax amount';
COMMENT ON COLUMN "Invoices"."TotalAmount" IS 'Total amount including tax';
COMMENT ON COLUMN "Invoices"."Notes" IS 'Additional notes for the invoice';

COMMENT ON COLUMN "InvoiceItems"."InvoiceId" IS 'Reference to parent invoice';
COMMENT ON COLUMN "InvoiceItems"."ParcelId" IS 'Reference to parcel from API';
COMMENT ON COLUMN "InvoiceItems"."WaybillNumber" IS 'Parcel waybill number';
COMMENT ON COLUMN "InvoiceItems"."Description" IS 'Item description';
COMMENT ON COLUMN "InvoiceItems"."Quantity" IS 'Quantity of items';
COMMENT ON COLUMN "InvoiceItems"."UnitPrice" IS 'Price per unit';
COMMENT ON COLUMN "InvoiceItems"."TotalPrice" IS 'Total price for this item';

-- Insert sample contract customer for testing (optional)
-- INSERT INTO "ContractCustomers" ("Name", "CompanyName", "Email", "Phone", "PaymentTerms", "CreatedById") 
-- VALUES ('Sample Customer', 'Sample Company Ltd', 'sample@example.com', '+254700000000', 'Net 30', 1);

-- Verify tables were created successfully
SELECT 
    table_name,
    column_name,
    data_type,
    is_nullable
FROM information_schema.columns 
WHERE table_name IN ('ContractCustomers', 'Invoices', 'InvoiceItems')
ORDER BY table_name, ordinal_position; 