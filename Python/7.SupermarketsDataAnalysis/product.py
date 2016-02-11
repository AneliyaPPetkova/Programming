class Product:

    def __init__(self, product_id, category):
        self.product_id = product_id
        self.category = category

        if any(v is None for v in [self.id, self.category]):
            raise ValueError('Arguments missing')
