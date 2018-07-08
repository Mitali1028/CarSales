(function () {
    'use strict';
    angular.module('app').controller('CarController', CarController);

    function CarController($http,$window)
    {
        var vm = this;
        var dataService = $http;
        vm.addClick = addClick;
        vm.editClick = editClick;
        vm.saveClick = saveClick;

        vm.car = {};

        vm.cars = [];

        function saveClick()
        {
            debugger;
            UpdateData();
            $window.location.href = "/Car/Index";
        }
        function addClick()
        {
            vm.car = initEntity();
        }

        function editClick(id)
        {
            debugger;
            GetCarForEdit(id);
            $window.location.href = "/Car/Edit/" + id;
        }

        function GetCarForEdit(id)
        {
            dataService.get("/api/Car/" + id)
            .then(function (result)
            {
                vm.car = result.data;
            },
            function(error)
            {
                handleException(error);
            });
        }
        function initEntity()
        {
            return {
                Id: 0,
                Make: '',
                Model: '',
                Engine: '',
                NoOfDoors: 0,
                BodyType:''
            };
        }

        function UpdateData()
        {
            dataService.put("/api/Car/" + vm.car.Id, vm.car)
            .then(function (result) {
                vm.car = result.data;
                var index = vm.cars.map(function (p) {
                    return p.Id;
                }).indexOf(vm.car.Id);

                vm.cars[index] = vm.car;
            },    
          
             function (error) {
                handleException(error);
            })
        }

         CarList();
         function CarList()
         {
             dataService.get("/api/Car")
            .then(function (result)
            {
                vm.cars = result.data;
                
            }, function (error)
            {
                handleException(error);
            });
             
         }

         function handleException(error)
         {
             alert(error.data.ExceptionMessage);
         }
    }



})();