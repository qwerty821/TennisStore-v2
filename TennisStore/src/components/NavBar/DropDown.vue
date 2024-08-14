<template>
	<a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
		{{ title }}
	</a>
	<ul class="dropdown-menu">
		<li v-for="(e, index) in processedData">
			<a :key="index" class="dropdown-item" :href="makeProductUrl(`/${getUrl(title)}/${e.url}`)">
				{{ e.category }}
			</a>
			<hr v-if="index < elements.length - 1" class="dropdown-divider">
		</li>
	</ul>

</template>

<script>

import { urlTransform } from '@/utils';

export default {
	props: {
		title: {
			type: String,
			required: true
		},
		elements: {
			type: Array,  // Changed from Object to Array
			required: true
		},

	},

	data() {
		return {
			catName: "aaa"
		}
	},

	computed: {
		processedData() {
			var x = this.elements.map(category => ({
				category,
				url: urlTransform(category)
			}));
			console.log(x[0].category);
			return x;
		}
	},

	methods: {
		getUrl(url) {
			return urlTransform(url);
		},
		makeProductUrl(url) {
			return "/Product" + url;
		}

	}

}
</script>

<style scoped></style>