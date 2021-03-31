<template>
    <div>
      <reading-list />  
      <router-link :to="{ name: 'add-book' }">Add Book to Reading List </router-link>
        
    </div>

</template>

<script>
import ReadingList from '../components/ReadingList.vue'
export default {
    name: "my-books",
    data(){
        return{
            isbn:0,
        }
    },
  components: {
       ReadingList 
    },
    created(){
        this.isbn = parseInt(this.$route.params.isbn)
    }

}
</script>

<style>

</style>