<template>
    <div class="container color-picker-layout m-0">
        <div class="row">
            <div class="col-sm-auto p-0 w-100">
                <input type="text" :value="value"  class="pt-0 hex">
                <label :for="colorPicker + value" class="m-0"><img src="~/assets/icones/eye-dropper-solid.svg" alt="conta-gotas" class="eye-dropper">
                    <input type="color" :id="colorPicker + value" :value="value" v-on:input="$emit('input', $event.target.value)">
                </label>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    props: [
        'value',
    ],
    data: function () {
        return{
            colorPicker: String
        }
    },
    methods: {
        
    }
}
</script>

<style>
    .color-picker-layout {
        width: auto;
    }

    .hex {
        padding: 0px;
        width: 95%;
        border-top: 0px;
        border-right: 0px;
        border-bottom: 1px solid black;
        border-left: 0px;
    }

    label > input[type=color] {
        display: none;
    }

    .eye-dropper {
        width: 16px;
        height: 16px;
        cursor: pointer;        
    }

    

</style>