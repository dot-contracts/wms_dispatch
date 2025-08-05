class InvoicingRouter:
    """
    A router to control all database operations on models for the
    invoicing application.
    """
    def db_for_read(self, model, **hints):
        """
        Suggest the database that should be used for reads of objects of type
        `model`.

        If no router has a suggestion (returns None), the connection
        manager will make the decision.
        """
        if model._meta.app_label == 'dispatch':
            # Check if it's an invoicing model
            if model._meta.model_name in ['contractcustomer', 'invoice', 'invoiceitem']:
                return 'invoicing'
        return None

    def db_for_write(self, model, **hints):
        """
        Suggest the database that should be used for writes of objects of type
        `model`.

        If no router has a suggestion (returns None), the connection
        manager will make the decision.
        """
        if model._meta.app_label == 'dispatch':
            # Check if it's an invoicing model
            if model._meta.model_name in ['contractcustomer', 'invoice', 'invoiceitem']:
                return 'invoicing'
        return None

    def allow_relation(self, obj1, obj2, **hints):
        """
        Allow any relation if a model in the invoicing app is involved.
        """
        if obj1._meta.app_label == 'dispatch' or obj2._meta.app_label == 'dispatch':
            # Check if it's an invoicing model
            if (obj1._meta.model_name in ['contractcustomer', 'invoice', 'invoiceitem'] or
                obj2._meta.model_name in ['contractcustomer', 'invoice', 'invoiceitem']):
                return True
        return None

    def allow_migrate(self, db, app_label, model_name=None, **hints):
        """
        Make sure the invoicing app's models get created on the right database.
        """
        if app_label == 'dispatch':
            # Check if it's an invoicing model
            if model_name in ['contractcustomer', 'invoice', 'invoiceitem']:
                return db == 'invoicing'
        return None 