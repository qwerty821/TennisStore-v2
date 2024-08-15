<template lang="">
  <section class="h-100 h-custom" style="background-color: #d2c9ff;">
    <div class="container py-5 h-100">
      <div class="row d-flex justify-content-center align-items-center h-100">
        <div class="col-12">
          <div class="card card-registration card-registration-2" style="border-radius: 15px;">
            <div class="card-body p-0">
				<div class="row g-0">
                <div class="col-lg-8">
                    <div class="p-5">
                    <div class="d-flex justify-content-between align-items-center mb-5">
                      <h1 class="fw-bold mb-0">Shopping Cart</h1>
                      <h6 class="mb-0 text-muted">3 items</h6>
                    </div>
                    <hr class="my-4">
                    <!-- Product -->

						<!-- <ChartViewProduct :product="items.value."></ChartViewProduct> -->
						<ChartViewProduct v-for="item in items"  :key="item.rId" :product="item" ></ChartViewProduct>
 
					<!--  -->
                    <hr class="my-4">
  
                    <div class="pt-5">
                      <h6 class="mb-0"><a href="/" class="text-body"><i
                            class="fas fa-long-arrow-alt-left me-2"></i>Back to shop</a></h6>
                    </div>
                  </div>
                </div>
                <div class="col-lg-4 bg-body-tertiary">
                  <div class="p-5">
                    <h3 class="fw-bold mb-5 mt-2 pt-1">Summary</h3>
                    <hr class="my-4">
  
                    <div class="d-flex justify-content-between mb-4">
                      <h5 class="text-uppercase">items {{cart.count}}</h5>
                      <h5>€ 132.00</h5>
                    </div>
  
                    <h5 class="text-uppercase mb-3">Shipping</h5>
  
                    <div class="mb-4 pb-2">
                      <select data-mdb-select-init>
                        <option value="1">Standard-Delivery- €5.00</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                        <option value="4">Four</option>
                      </select>
                    </div>
  
                    <h5 class="text-uppercase mb-3">Give code</h5>
  
                    <div class="mb-5">
                      <div data-mdb-input-init class="form-outline">
                        <input type="text" id="form3Examplea2" class="form-control form-control-lg" />
                        <label class="form-label" for="form3Examplea2">Enter your code</label>
                      </div>
                    </div>
  
                    <hr class="my-4">
  
                    <div class="d-flex justify-content-between mb-5">
                      <h5 class="text-uppercase">Total price</h5>
                      <h5>€ 137.00</h5>
                    </div>
  
                    <button  type="button" data-mdb-button-init data-mdb-ripple-init class="btn btn-dark btn-block btn-lg"
                      data-mdb-ripple-color="dark">Register</button>
  
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script setup>
import { fetchData } from '@/apiServices';
import ChartViewProduct from './Products/ChartViewProduct.vue';
import { cartStore } from '@/stores/cart';
import { onMounted, ref } from 'vue'
import { reactive, computed } from 'vue'

const cart = cartStore();

const items = ref([]);


onMounted(async () => {
	for (let [key, val] of cart.items) {
		const response = await fetchData('https://localhost:44388/api/Racket/get', { 'id': key });
		console.log("key" + key);
		items.value.push(response);
	}
 
});


</script>
<style scoped>
@media (min-width: 1025px) {
	.h-custom {
		height: 100vh !important;
	}
}

.card-registration .select-input.form-control[readonly]:not([disabled]) {
	font-size: 1rem;
	line-height: 2.15;
	padding-left: .75em;
	padding-right: .75em;
}

.card-registration .select-arrow {
	top: 13px;
}


input[type="number"]::-webkit-inner-spin-button,
input[type="number"]::-webkit-outer-spin-button {
	-webkit-appearance: none;
	margin: 0;
}

/* Pentru browserele Firefox */
input[type="number"] {
	appearance: textfield;
}
</style>