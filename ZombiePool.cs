using System.Collections.Generic;

namespace Pvz
{
    public class ZombiePool
    {
        private Queue<Zombie> pool;

        public ZombiePool(int size)
        {
            pool = new Queue<Zombie>(size);
            for (int i = 0; i < size; i++)
            {
                pool.Enqueue(new Zombie(1)); // Tạo zombie với cấp độ 1
            }
        }

        public Zombie GetZombie(int level)
        {
            return pool.Count > 0 ? pool.Dequeue() : new Zombie(level); // Lấy zombie từ pool
        }

        public void ReleaseZombie(Zombie zombie)
        {
            pool.Enqueue(zombie); // Đưa zombie trở lại pool
        }
    }
}
