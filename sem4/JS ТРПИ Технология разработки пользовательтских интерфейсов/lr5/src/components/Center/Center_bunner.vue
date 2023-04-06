<template>
  <div :class="$style['footer_bunner']">
    <h1>
      Align is the stress-free way to build your website.
    </h1>
    <div :class="$style['footer_bunner_dop_info']">
      <h5>
        $79
      </h5>
      <p>
        Build a better website
        faster today.
      </p>
      <p
          @click="isVoiceModalOpen = !isVoiceModalOpen"
          v-bind:class="{ animated: isHover, footer_bunner__button: NoHover}"
          v-on:mouseover="isHover = true, NoHover = false"
          v-on:mouseout="isHover = false, NoHover = true"
      >Purchase</p>

      <Transition name="SpawnModal">
        <BaseModal
            v-if="isVoiceModalOpen"
            @close="isVoiceModalOpen = false"
            :ModelWindowContent="ModalWindow"
        >

        </BaseModal>
      </Transition>

    </div>
  </div>
</template>

<!--
//TODO анимирование кнопки
-->

<script>
import BaseModal from "@/components/Base/BaseModal";

import styles from "@/components/Center/CenterComponent.module.css";

export default {
  name: "Center_bunner",
  components:{BaseModal},
  data(){
    return{
      isHover: false,
      NoHover: true,
      isVoiceModalOpen: false,
      ModalWindow:'$79'
    }
  },
  methods:{
    handleItemClick(image){
      image.class = 'ViewImg'
    }
  },
  computed: {
    $style() {
      return styles;
    }
  }
}
</script>

<style scoped>

  /*Анимация появления\исчезания модального окна*/
  .SpawnModal-enter-active,
  .SpawnModal-leave-active {
    transition: opacity 0.5s ease;
  }

  .SpawnModal-enter-from,
  .SpawnModal-leave-to {
    opacity: 0;
  }

  .footer_bunner__button{
    background: #84A17D;
    border-radius: 4px;
    padding: 12px 42px 12px 42px;
    text-align: center;

    font-family: 'Roboto';
    font-style: normal;
    font-weight: 400;
    font-size: 13px;
    line-height: 24px;
    /* identical to box height, or 185% */

    text-align: center;

    color: #FFFFFF;
    transition: all 0.5s ease;
  }

  /*Анимация кнопки*/
  .animated{
    background: #546750;
    border-radius: 4px;
    padding: 12px 42px 12px 42px;
    text-align: center;

    font-family: 'Roboto';
    font-style: normal;
    font-weight: 400;
    font-size: 13px;
    line-height: 24px;
    /* identical to box height, or 185% */

    scale: 95%;

    text-align: center;

    color: #FFFFFF;
    transition: all 0.5s ease;
  }
</style>