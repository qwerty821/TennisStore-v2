import { defineStore } from "pinia";

export const cartStore = defineStore("cart", {
	state: () => {
		return {
			name: "Cart",
			items: new Map(),

		};
	},
	getters: {
		count: (state) => state.items.size,  
	},

	actions: {
		addItem(id) {
			if (!this.items.has(id)) {
				this.items.set(id, 1);
			} else {
				this.items[id]++;
			}
		},
		
		removeItem(id) {
			this.items.delete(id);
		},
	}
});
