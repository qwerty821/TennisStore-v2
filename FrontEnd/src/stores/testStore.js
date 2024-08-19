import { contains } from "jquery";
import { defineStore } from "pinia";
import { ref } from "vue";
export const testStore = defineStore("TestStore", {
	state: () => {
		return {
			count: ref(0),
            list: ref([])
		}
	},

	getters: {
		getCount() {
            return "count =" + this.count;
        }
	},
	 
	actions: {
		addItem(id) {
            this.list[id] = 1; 
        }, 
        contains(id) {
            if (this.list[id]) {
                return true;
            } else {
                return false;
            }
        },
        removeItem(id) {
            if (this.list[id]) {
                delete this.list[id];
            }
        }
	}
});
