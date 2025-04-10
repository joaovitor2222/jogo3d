using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GameBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // Simulando o dano do inimigo
        [HttpGet("enemyDamage")]
        public async Task<IActionResult> GetEnemyDamage()
        {
            // Dano do inimigo por segundo
            int enemyDamage = 100;
            await Task.Delay(1000);  // Espera 1 segundo para simular o dano
            return Ok(new { damage = enemyDamage });
        }
    }
}
