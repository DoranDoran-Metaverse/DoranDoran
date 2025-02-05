using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCNodState : MonoBehaviour, INPCState
{
    private NPCController _npcController;
   
    public void OnStateEnter(NPCController npcController)
    {
        if (!_npcController)
            _npcController = npcController;

        _npcController.anim.SetBool("Nod", true);
        _npcController._navMeshAgent.isStopped = true; // NPC ������ ����
    }
    public void OnStateUpdate()
    {
        Debug.Log("NPC Nod Q");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _npcController.ChangeState(_npcController._thinkState);
        }
    }

    public void OnStateExit()
    {
        _npcController.anim.SetBool("Nod", false);
    }

}

