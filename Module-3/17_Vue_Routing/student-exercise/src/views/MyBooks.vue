<template>
    <div>
         <reading-list /> 
         <footer>
             <router-link :to="{name: 'new-book'}"> Add Book to Reading List </router-link>
         </footer>
    </div>

</template>

<script>
import ReadingList from '../components/ReadingList.vue'
export default {
    name: "my-books",
  components: {
       ReadingList 
    },

}
</script>

<style>

</style>