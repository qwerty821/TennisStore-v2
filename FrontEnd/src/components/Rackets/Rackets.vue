<template lang="">
    <div class="products">
        <RacketCard v-for="(prod, index) in products" :product="prod" >
            <template #headerrr>
                <h1>Here might be a page title</h1>
              </template>
        </RacketCard>
    </div>
</template>
<script setup>
import { fetchData } from '@/apiServices';
import RacketCard from './RacketCard.vue';
import { ref } from 'vue';
import { onMounted } from 'vue';

var products = ref([]);

onMounted(async () => {
    products.value =  await fetchData("https://localhost:44388/api/Racket/get/all");
})

</script>
<style>
    .products {
        width: 100%;
        display:flex;
        flex-direction: row;
        flex-wrap: wrap;
    }
</style>