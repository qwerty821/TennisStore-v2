
<template>
	<NavBar :data="categories"></NavBar>
	<router-view></router-view>
  </template>
  
  <script>

	import NavBar from './components/NavBar/NavBar.vue';
	 

	var str =  `{ "categories":  [
				{"name" :"Rackets rack", "data" : ["Babolat", "Wilson", "Head", "Tecnifibre"]},
				{"name" : "Balls balls",  "data" : []},
				{"name" : "Grips", "data": ["Overgrips", "Replacement Grips"]},
				{"name" : "Brands", "data" : ["Babolat", "Wilson", "Head", "Tecnifibre", "Nike", "Adidas"]}
			]}`
	var obj = JSON.parse(str);
	


  export default {
	name: 'App',

	components: {
		NavBar
	},
	
	data() {
		return {
			categories: obj.categories
		}
	},

	methods: {
		AddToChartProd() {
			console.log("aaaaaaaaddddd");
		}
	}
  }
  </script>
  