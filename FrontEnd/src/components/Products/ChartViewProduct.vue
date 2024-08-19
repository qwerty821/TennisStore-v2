<template>
	<div class="row mb-4 d-flex justify-content-between align-items-center" v-if="contains()">
		<div class="col-md-2 col-lg-2 col-xl-2">
			<img :src="product.imageUrl" class="img-fluid rounded-3" alt="Cotton T-shirt">
		</div>
		<div class="col-md-3 col-lg-3 col-xl-3">
			<!-- <h6 class="text-muted">{{product.rBrand}}</h6> -->
			<h6 class="mb-0">{{ props.product.name }}</h6>
		</div>
		<div class="col-md-3 col-lg-3 col-xl-3 d-flex">
			<button data-mdb-button-init data-mdb-ripple-init class="btn btn-link px-2" @click="sub">
				<i class="fas fa-minus"></i>
			</button>

			<input id="form1" min="0" name="quantity" :value="quantity" type="number"
				class="form-control form-control-sm" />

			<button data-mdb-button-init data-mdb-ripple-init class="btn btn-link px-2" @click="add">
				<i class="fas fa-plus"></i>
			</button>
		</div>
		<div class="col-md-3 col-lg-2 col-xl-2 offset-lg-1">
			<h6 class="mb-0"> <span v-if="quantity > 1">{{quantity}} 
				<span class="material-symbols-outlined" style="font-size: 10px;">
				close
				</span> 
			</span> {{ product.price }} $</h6>
		</div>
		<div class="col-md-1 col-lg-1 col-xl-1 text-end">
			<a href="#!" class="text-muted"><i class="fas fa-times"></i></a>
		</div>
	</div>
</template>
<script setup>
import { computed, onMounted, watch } from 'vue'
import { ref } from 'vue';
import { cartStore } from '@/stores/cart'

const quantity = ref(0);
const cart = cartStore();
const props = defineProps({
	product: {
		type: Object,
		required: true
	}
});

const inc = ref(0);
const dec = ref(0);

watch(inc, (newVal, oldVal) => {
	cart.count++;
});
watch(dec, (newVal, oldVal) => {
	cart.count--;
});


function add() {
	inc.value += 1; dec.value = 0;
	cart.incQuantity(props.product.id);
}
function sub() {
	dec.value += 1; inc.value = 0;
	cart.decQuantity(props.product.id);
}

onMounted(() => {
	quantity.value = cart.getQuantity(props.product.id);
});

watch(cart.items, () => {
	quantity.value = cart.getQuantity(props.product.id);
}, {
	immediate: true
});

function contains() {
	return cart.contains(props.product.id);
};

</script>
<style lang="">

</style>