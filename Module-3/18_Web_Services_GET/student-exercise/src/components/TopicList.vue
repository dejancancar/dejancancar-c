<template>
  <div class="topic-list">
    <div v-for="topic in topics" v-bind:key="topic.id" class="topic">
      <router-link :to="{name: 'Messages', params: { id: topic.id}}"> {{ topic.title }} </router-link>
    </div>

    <topic-details />
  </div>
</template>

<script>
import apiService from '../service/apiService.js'
import TopicDetails from '../components/TopicDetails.vue'
export default {
  name: 'topic-list',
  components:{
    TopicDetails,
  },
  data() {
    return {
      topics: []
    }
  },
  created(){
    apiService.getTopics().then( (resp) => {
      this.topics = resp.data;
    });
  }
}
</script>

<style>
.topic-list {
  padding: 20px 20px;
  margin: 0 auto;
  max-width: 600px;
}
.topic {
  font-size: 24px;
  border-bottom: 1px solid #f2f2f2;
  padding: 10px 20px;
}
.topic:last-child {
  border: 0px;
}
</style>