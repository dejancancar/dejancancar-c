<template>
  <div>
      <h1>{{book.title}}</h1>
  </div>
</template>

<script>
export default {
    name: 'book-details',
    props: {
        isbn: Number,
    },
    data(){
        return{
            book: {

            }
        }
    }
}
</script>

<style>

</style>