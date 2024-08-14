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
  			"id": "c6f4facd-952b-4ca9-99c9-1bdf39f3809b",
			"name": "Pure Drive",
			"imageUrl" : "https://media.babolat.com/image/upload/f_auto,q_auto,c_pad,w_1008,h_1008/v1698313553/Product_Media/2024/Tennis/Racquets/Expert/102541-Pure_Drive_Anniversary-100-1-Face.png",
			"price": "270$",
			"brand" : "Babolat"
		}, 
		{
  			"id": "2785c575-ff66-479a-b5b9-ef80a616f4ec",
			"name": "Pure Aero 98",
			"imageUrl" : "https://media.babolat.com/image/upload/f_auto,q_auto,c_pad,w_1008,h_1008/v1651570894/Product_Media/2023/TENNIS_RACKETS/EXPERT/101499-Pure_Aero_98-370-1-Face.png",
			"price": "259$",
			"brand" : "Babolat"
		}, 
		{
  			"id": "0579d8cd-cfa6-4466-a669-c8acb8417a57",
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