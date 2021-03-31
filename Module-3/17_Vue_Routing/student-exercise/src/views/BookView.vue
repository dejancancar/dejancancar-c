<template>
  <div>
    <book-details />
  </div>
</template>

<script>

import BookDetails from "../components/BookDetails.vue";
export default {
  name: "book-view",
  components: {
    BookDetails
  },

  data() {
    return {
      isbn: 0,
    };
  },
  method: {
    book() {
      return this.$store.state.book.find((b) => {
        return b.isbn == this.isbn;
      });
    },
  },
  created() {
    this.isbn = parseInt(this.$route.params.isbn);
  },
};
</script>

<style>
</style>