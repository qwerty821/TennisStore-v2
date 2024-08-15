<template lang="">
    <div class="products">
        <RacketCard v-for="(prod, index) in products" :product="prod" >
            <template #headerrr>
                <h1>Here might be a page title</h1>
              </template>
        </RacketCard>
    </div>
</template>
<script>
import RacketCard from './RacketCard.vue';


var rString= `
	[
		{
  			"id": "49763095-0A90-4688-B571-13BC20E46C0B",
			"name": "Pure Drive",
			"imageUrl" : "https://media.babolat.com/image/upload/f_auto,q_auto,c_pad,w_1008,h_1008/v1698313553/Product_Media/2024/Tennis/Racquets/Expert/102541-Pure_Drive_Anniversary-100-1-Face.png",
			"price": "270$",
			"brand" : "Babolat"
		}, 
		{
  			"id": "713F677A-BBA2-45E9-BD5A-76163AF8531A",
			"name": "Pure Aero 98",
			"imageUrl" : "https://media.babolat.com/image/upload/f_auto,q_auto,c_pad,w_1008,h_1008/v1651570894/Product_Media/2023/TENNIS_RACKETS/EXPERT/101499-Pure_Aero_98-370-1-Face.png",
			"price": "259$",
			"brand" : "Babolat"
		}, 
		{
  			"id": "BBCA3C62-D63D-4A2F-99C3-E990A4A2377F",
			"name": "Boost Strike",
			"imageUrl" : "https://media.babolat.com/image/upload/f_auto,q_auto,c_pad,w_1008,h_1008/v1683710566/Product_Media/2024/Tennis/Racquets/Intermediaire/121247-Boost_Strike-100-1-Face.png",
			"price": "94.99$",
			"brand" : "Babolat"
		}
	]`;
	var racketObj = JSON.parse(rString);


  	var prods = racketObj;



export default {

    components: {
        RacketCard
    },

    data() {
        return {
            products: prods
        };
    },

    methods: {
        SendToMainChart() {
            this.$emit("add-to-chart");
        }
    }
}
</script>
<style>
    .products {
        width: 100%;
        display:flex;
        flex-direction: row;
        flex-wrap: wrap;
    }
</style>