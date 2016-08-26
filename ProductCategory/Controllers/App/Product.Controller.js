(function () {
    angular.module("ProductView").controller("FnProductCat", FnProductCat);
    function FnProductCat($http)
    {
        var vm = this;
        var service = $http;
        vm.products = [];
        vm.searchCategories = [];
        productList();
        searchCategoryList();
        
        function productList() {
           
            service.get("/api/Product")
            .then(function (result) {
              
                vm.products = result.data;
            }, function (error) { handleException(error)});
        }

        vm.searchInput = {
            selectedCategory: {
                CategoryId: 0,
                CategoryName: ''
            }, productName: ''
        };
        function searchCategoryList() {
            alert('function called');
            service.get("/api/Category")
                .then(function (result) {
                    
                    vm.searchCategories = result.data;
                }, function (error) { handleException(error) });
        }

        function  handleException(error)
        {
            alert(error.data.ExceptionMessage);
        }
     }
})();