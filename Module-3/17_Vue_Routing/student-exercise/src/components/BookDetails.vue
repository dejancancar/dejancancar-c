<template>
  <div>
      <h1>{{book.title}}</h1>
      <h1>{{book.author}}</h1>
        <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '.jpg'" />
      <p>{{book.read ? "I have read this book" : "I have not read this book"}}</p>
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

            },
            
        }
    },
    created(){
        return this.$store.state.books.find((b) => {
          if(b.isbn == this.isbn){
             this.book = b;
          }
    });

    }
}
</script>

<style>

</style>