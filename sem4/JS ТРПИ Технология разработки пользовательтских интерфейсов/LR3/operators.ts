interface Person{
    name: string
    age: number
}

type PersoneKey = keyof Person

const myName: PersoneKey = 'name'

let key: PersoneKey = 'name'
key = 'age'
//key = 'number'

type User = {
    id: number
    name: string
    email: string
    createAt : Date
}

type UserKeysNoMeta1 = Exclude<keyof User, 'id' | 'createAt'>
type UserKeysNoMeta2 = Pick<User, 'name' | 'email'>

let u1: UserKeysNoMeta1 = 'name'
