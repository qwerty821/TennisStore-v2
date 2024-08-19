<template >
    <div class="title" v-if="contains()">
        <h1>Test</h1>
        <button @click.preventDefault="inc">+</button>
        <div>{{store.count}}</div>
        <button @click.preventDefault="dec">-</button>
    </div>
</template>
<script setup>
import { testStore } from '@/stores/testStore';
import { onMounted } from 'vue';

const store = testStore();
const t_id = "aa";
onMounted(() =>{
    store.addItem(t_id);
}); 

function inc() {
    store.addItem(t_id);
}
function dec() {
    store.removeItem(t_id);
}

function contains() {
    return store.contains(t_id);
}
</script>
<style>
.title { 
    text-align: center;
}
</style>