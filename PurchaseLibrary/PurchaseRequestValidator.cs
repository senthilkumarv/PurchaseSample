namespace PurchaseHelper
{
    public class PurchaseRequestValidator
    {
        private readonly PurchaseRepository purchaseRepository;

        public PurchaseRequestValidator()
        {
            purchaseRepository = new PurchaseRepository();
        }

        public Error Validate(PurchaseRequest request)
        {
            
            if(!purchaseRepository.IsValidCustomer(request.customerId))
            {
                return new Error
                    {
                        Code = "1001",
                        Message = "Invalid Customer Id"
                    };
            }
            
            if(!purchaseRepository.IsValidProduct(request.productId))
            {
                return new Error
                           {
                               Code = "1002",
                               Message = "Invalid Product Id"
                           };
            }

            return null;
        }
    }
}
